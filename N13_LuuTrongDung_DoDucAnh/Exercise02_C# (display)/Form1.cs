using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Structures;

namespace Display
{
    public partial class Form1 : Form
    {
        public class Position
        {
            public int x;
            public int y;

            public Position() { }

            public Position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override bool Equals(object obj)
            {
                if (obj is Position pos)
                    return this.x == pos.x && this.y == pos.y;
                return false;
            }

            public override int GetHashCode()
            {
                return (x, y).GetHashCode();
            }
        }

        public class Game
        {
            public int[,] map = new int[29, 29];
            public Position posStart = new Position(5, 5);
            public Position posEnd = new Position(26, 19);
            public Structures.Queue<Position> pathDfs = new Structures.Queue<Position>();
            public Structures.Stack<Position> pathBfs = new Structures.Stack<Position>();

            public void Dfs()
            {
                Structures.Stack<Position> stack = new Structures.Stack<Position>();
                stack.Push(posStart);


                HashSet<Position> visited = new HashSet<Position>();
                visited.Add(posStart);
                pathDfs.EnQueue(posStart);

                Position[] moves = new Position[]
                {
                    new Position(0, -1),
                    new Position(-1, 0),
                    new Position(0, 1),
                    new Position(1, 0)
                };

                while (!pathDfs.rear.info.Equals(posEnd))
                {
                    Position current = pathDfs.rear.info;

                    bool foundMove = false;
                    var shuffledMoves = moves.OrderBy(_ => Guid.NewGuid()).ToArray();
                    foreach (var move in shuffledMoves)
                    {
                        Position neighbor = new Position(current.x + move.x, current.y + move.y);
                        if (neighbor.x >= 1 && neighbor.x < 29 - 1 && neighbor.y >= 1 && neighbor.y < 29 - 1 && map[neighbor.x, neighbor.y] == 0 && !visited.Contains(neighbor))
                        {
                            pathDfs.EnQueue(neighbor);
                            visited.Add(neighbor);
                            stack.Push(neighbor);
                            foundMove = true;
                            break;
                        }
                    }

                    if (!foundMove)
                    {
                        if (!stack.IsEmpty())
                        {
                            stack.Pop();
                        }
                        if (!stack.IsEmpty())
                        {
                            pathDfs.EnQueue(stack.Peek().info);
                        }
                        else
                            break;
                    }
                }
            }

            public void Bfs()
            {
                Structures.Queue<Position> openList = new Structures.Queue<Position>();
                openList.EnQueue(posStart);

                var visited = new HashSet<Position> { posStart };
                var parents = new Dictionary<Position, Position> { [posStart] = null };

                Position[] moves = new Position[]
                {
                    new Position(0, -1),
                    new Position(-1, 0),
                    new Position(0, 1),
                    new Position(1, 0)
                };

                while (!openList.IsEmpty())
                {
                    Position current = openList.Front().info;
                    openList.DeQueue();

                    if (current.x == posEnd.x && current.y == posEnd.y)
                        break;

                    var shuffledMoves = moves.OrderBy(_ => Guid.NewGuid()).ToArray();

                    foreach (var direction in shuffledMoves)
                    {
                        var neighbor = new Position(current.x + direction.x, current.y + direction.y);

                        if (neighbor.x >= 1 && neighbor.x < 29 - 1 && neighbor.y >= 1 && neighbor.y < 29 - 1 && map[neighbor.x, neighbor.y] == 0 && !visited.Contains(neighbor))
                        {
                            visited.Add(neighbor);
                            openList.EnQueue(neighbor);
                            parents[neighbor] = current;
                        }
                    }
                }

                if (!parents.ContainsKey(posEnd))
                {
                    Console.WriteLine("No path found!");
                    return;
                }

                Position trace = posEnd;

                while (trace != null)
                {
                    pathBfs.Push(trace);
                    trace = parents[trace];
                }
            }

            public void CreateMap()
            {
                for (int i = 0; i < 29; i++)
                {
                    for (int j = 0; j < 29; j++)
                    {
                        map[i, j] = 1;
                    }
                }

                Position[] moves = new Position[]
                {
                    new Position(0, -2),
                    new Position(-2, 0),
                    new Position(0, 2),
                    new Position(2, 0)
                };

                Structures.Stack<Position> stack = new Structures.Stack<Position>();

                map[posStart.x, posStart.y] = 0;
                map[posEnd.x, posEnd.y] = 0;

                Random rand = new Random();
                moves = moves.OrderBy(x => rand.Next()).ToArray();

                foreach (var move in moves)
                {
                    int nx = posStart.x + move.x;
                    int ny = posStart.y + move.y;

                    if (nx >= 1 && nx < 29 - 1 && ny >= 1 && ny < 29 - 1)
                    {
                        map[nx, ny] = 0;
                        map[posStart.x + (move.x / 2), posStart.y + (move.y / 2)] = 0;
                        stack.Push(new Position(nx, ny));
                    }
                }

                map[posStart.x + 3, posStart.y] = 0;
                map[posStart.x - 3, posStart.y] = 0;

                while (!stack.IsEmpty())
                {
                    moves = moves.OrderBy(m => rand.Next()).ToArray();

                    Position lastPos = stack.Peek().info;
                    int x = lastPos.x;
                    int y = lastPos.y;

                    bool foundMove = false;

                    foreach (var move in moves)
                    {
                        int nx = x + move.x;
                        int ny = y + move.y;

                        if (nx == posEnd.x && ny == posEnd.y)
                        {
                            return;
                        }

                        if (nx >= 1 && nx < 29 - 1 && ny >= 1 && ny < 29 - 1 && map[nx, ny] == 1)
                        {
                            map[nx, ny] = 0;
                            map[x + move.x / 2, y + move.y / 2] = 0;
                            stack.Push(new Position(nx, ny));
                            foundMove = true;
                            break;
                        }
                    }

                    if (!foundMove)
                    {
                        stack.Pop();
                    }
                }
            }
        }

        public Game run = new Game();

        public Form1()
        {
            InitializeComponent();
            run.CreateMap();
            run.Dfs();
            run.Bfs();
            this.DoubleBuffered = true;
        }

        private bool dfsOn = false;
        private bool bfsOn = false;
        private int time = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void dfs_Click(object sender, EventArgs e)
        {
            dfsOn = !dfsOn;
        }

        private void bfs_Click(object sender, EventArgs e)
        {
            bfsOn = !bfsOn;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            bool redrawRequired = false;

            if (dfsOn && 0 < run.pathDfs.count)
            {
                Position current = run.pathDfs.Front().info;
                run.pathDfs.DeQueue();
                redrawRequired = true;
            }

            if (bfsOn && 0 < run.pathBfs.count)
            {
                Position current = run.pathBfs.Peek().info;
                run.pathBfs.Pop();
                redrawRequired = true;
            }

            if (redrawRequired)
            {
                panel1.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(panel1.BackColor);

            int cellSize = 27;

            for (int i = 0; i < 29; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    if (run.map[i, j] == 1)
                    {
                        g.FillRectangle(Brushes.Black, j * cellSize, i * cellSize, cellSize, cellSize);
                    }
                }
            }

            if (dfsOn && 0 < run.pathDfs.count)
            {
                Position current = run.pathDfs.Front().info;
                Brush dfsBrush = Brushes.Yellow;
                g.FillRectangle(dfsBrush, current.y * cellSize, current.x * cellSize, cellSize, cellSize);
            }

            if (bfsOn && 0 < run.pathBfs.count)
            {
                Position current = run.pathBfs.Peek().info;
                Brush bfsBrush = Brushes.Orange;
                g.FillRectangle(bfsBrush, current.y * cellSize, current.x * cellSize, cellSize, cellSize);
            }

            Brush startBrush = Brushes.Green;
            Brush endBrush = Brushes.Red;

            g.FillRectangle(startBrush, run.posStart.y * cellSize, run.posStart.x * cellSize, cellSize, cellSize);
            g.FillRectangle(endBrush, run.posEnd.y * cellSize, run.posEnd.x * cellSize, cellSize, cellSize);
        }


    }
}
