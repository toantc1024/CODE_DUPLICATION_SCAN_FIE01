
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _8PuzzleGame
{
    public partial class Form1 : Form
    {
        private int[] currentPuzzle;
        private int[] goalState = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
        private int[] initialPuzzle; 
        private Queue<string> solutionSteps; // Lưu trữ các bước đi
        private System.Windows.Forms.Timer solveTimer;         // Timer để cập nhật từng bước
        private int currentStepIndex;    

        public Form1()
        {
            InitializeComponent();
            initialPuzzle = CreateInitialPuzzle(); // Lưu trạng thái ban đầu
            currentPuzzle = (int[])initialPuzzle.Clone(); // Khởi tạo trạng thái ban đầu của trò chơi

            solutionSteps = new Queue<string>(); // Khởi tạo Queue để lưu trữ các bước đi

            // Khởi tạo Timer
            solveTimer = new System.Windows.Forms.Timer();
            solveTimer.Interval = 500; // Cập nhật mỗi 500ms (hoặc thay đổi theo yêu cầu)
            solveTimer.Tick += SolveTimer_Tick;
        }
        private void SolveTimer_Tick(object sender, EventArgs e)
        {
            if (solutionSteps.Count > 0)
            {
                // Lấy bước tiếp theo từ queue (bây giờ là các bước di chuyển string)
                string nextMove = solutionSteps.Dequeue();

                // Cập nhật trạng thái puzzle theo bước đi
                PerformMove(nextMove);

                // Vẽ lại trạng thái mới của puzzle
                pnlPuzzle.Invalidate();

                // Tăng chỉ số bước
                currentStepIndex++;

                // Nếu đạt đến trạng thái goal state, dừng Timer
                if (currentPuzzle.SequenceEqual(goalState))
                {
                    solveTimer.Stop(); // Dừng Timer khi giải quyết xong
                    lblSteps.Text = "Puzzle solved!";
                }
            }
        }
        private void PerformMove(string move)
        {
            int emptyIndex = Array.IndexOf(currentPuzzle, 0);
            int newIndex = -1;

            switch (move)
            {
                case "up":
                    newIndex = emptyIndex - 3; // Di chuyển lên
                    break;
                case "down":
                    newIndex = emptyIndex + 3; // Di chuyển xuống
                    break;
                case "left":
                    newIndex = emptyIndex - 1; // Di chuyển sang trái
                    break;
                case "right":
                    newIndex = emptyIndex + 1; // Di chuyển sang phải
                    break;
            }

            // Kiểm tra di chuyển hợp lệ
            if (newIndex >= 0 && newIndex < 9 && (Math.Abs(emptyIndex % 3 - newIndex % 3) <= 1))
            {
                // Swap giá trị
                int temp = currentPuzzle[emptyIndex];
                currentPuzzle[emptyIndex] = currentPuzzle[newIndex];
                currentPuzzle[newIndex] = temp;
            }
        }
        

        // Phương thức để tạo trạng thái ban đầu ngẫu nhiên
        private int[] CreateInitialPuzzle()
        {
            Random rand = new Random();
            int[] puzzle = (int[])goalState.Clone();
            for (int i = 0; i < 100; i++)
            {
                int emptyIndex = Array.IndexOf(puzzle, 0);
                int[] directions = { -1, 1, -3, 3 }; // Left, Right, Up, Down
                int direction = directions[rand.Next(directions.Length)];
                int newIndex = emptyIndex + direction;

                // Kiểm tra các điều kiện di chuyển hợp lệ
                if (newIndex >= 0 && newIndex < 9 && (Math.Abs(emptyIndex % 3 - newIndex % 3) <= 1))
                {
                    puzzle[emptyIndex] = puzzle[newIndex];
                    puzzle[newIndex] = 0;
                }
            }

            return puzzle;
        }

        public class PuzzleState
        {
            public int[] Puzzle { get; set; }
            public int EmptyIndex { get; set; }
            public string Path { get; set; }

            public PuzzleState(int[] puzzle, int emptyIndex, string path)
            {
                Puzzle = puzzle;
                EmptyIndex = emptyIndex;
                Path = path;
            }
        }

        // Phương thức xử lý sự kiện Solve khi nhấn nút
        private void btnSolve_Click(object sender, EventArgs e)
        {
            // Gọi thuật toán giải quyết puzzle (BFS) để lấy các bước đi dưới dạng Queue<string>
            solutionSteps = SolvePuzzleBFS(currentPuzzle);
            lblSteps.Text = "Steps to solve: " + string.Join(",", solutionSteps);

            // Đặt lại chỉ số bước hiện tại
            currentStepIndex = 0;

            // Bắt đầu chạy Timer để cập nhật trạng thái puzzle từng bước
            solveTimer.Start();
        }
        private void pnlGoalState_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            for (int i = 0; i < 9; i++)
            {
                int x = (i % 3) * 60;
                int y = (i / 3) * 60;
                int tile = goalState[i];

                if (tile == 0)
                {
                    g.FillRectangle(System.Drawing.Brushes.Gray, x, y, 60, 60);
                }
                else
                {
                    g.FillRectangle(System.Drawing.Brushes.LightGreen, x, y, 60, 60);
                    g.DrawString(tile.ToString(), new System.Drawing.Font("Arial", 20),
                        System.Drawing.Brushes.Black, x + 20, y + 20);
                }
            }
        }
        // Phương thức giải quyết bài toán với thuật toán BFS
        private Queue<string> SolvePuzzleBFS(int[] startState)
        {
            Queue<PuzzleState> queue = new Queue<PuzzleState>();
            HashSet<string> visited = new HashSet<string>();
            Dictionary<string, string> cameFrom = new Dictionary<string, string>();

            queue.Enqueue(new PuzzleState(startState, Array.IndexOf(startState, 0), ""));
            visited.Add(string.Join(",", startState));

            Queue<string> solutionSteps = new Queue<string>();

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                int[] puzzle = current.Puzzle;
                int emptyIndex = current.EmptyIndex;
                string path = current.Path;

                if (puzzle.SequenceEqual(goalState))
                {
                    // Lưu các bước vào Queue (chỉ cần lưu các bước đi)
                    foreach (var move in path.Split(','))
                    {
                        solutionSteps.Enqueue(move); // Lưu bước di chuyển
                    }
                    return solutionSteps;
                }

                int[] directions = { -1, 1, -3, 3 };
                string[] moves = { "left", "right", "up", "down" };

                for (int i = 0; i < directions.Length; i++)
                {
                    int newIndex = emptyIndex + directions[i];
                    if (newIndex >= 0 && newIndex < 9 && (Math.Abs(emptyIndex % 3 - newIndex % 3) <= 1))
                    {
                        int[] newPuzzle = (int[])puzzle.Clone();
                        newPuzzle[emptyIndex] = newPuzzle[newIndex];
                        newPuzzle[newIndex] = 0;

                        string newPuzzleString = string.Join(",", newPuzzle);

                        if (!visited.Contains(newPuzzleString))
                        {
                            visited.Add(newPuzzleString);
                            string newPath = path + "," + moves[i];
                            queue.Enqueue(new PuzzleState(newPuzzle, newIndex, newPath));
                        }
                    }
                }
            }
            return solutionSteps;
        }

        // Vẽ lại trạng thái của puzzle
        private void pnlPuzzle_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            for (int i = 0; i < 9; i++)
            {
                int x = (i % 3) * 60;
                int y = (i / 3) * 60;
                int tile = currentPuzzle[i];

                if (tile == 0)
                {
                    g.FillRectangle(System.Drawing.Brushes.Gray, x, y, 60, 60);
                }
                else
                {
                    g.FillRectangle(System.Drawing.Brushes.LightBlue, x, y, 60, 60);
                    g.DrawString(tile.ToString(), new System.Drawing.Font("Arial", 20),
                        System.Drawing.Brushes.Black, x + 20, y + 20);
                }
            }
        }

        // Khi form tải
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlPuzzle.Invalidate(); // Cập nhật lại trạng thái hiển thị ban đầu
        }
    }
}