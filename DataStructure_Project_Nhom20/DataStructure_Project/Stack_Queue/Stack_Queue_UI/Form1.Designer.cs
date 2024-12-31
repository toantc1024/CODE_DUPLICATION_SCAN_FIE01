namespace _8PuzzleGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Panel pnlGoalState;
        private System.Windows.Forms.Panel pnlPuzzle;
        private System.Windows.Forms.Label lblGoalState;
        private System.Windows.Forms.Label lblInstructions;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblSteps = new System.Windows.Forms.Label();
            this.pnlGoalState = new System.Windows.Forms.Panel();
            this.pnlPuzzle = new System.Windows.Forms.Panel();
            this.lblGoalState = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();

            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(300, 20);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(100, 40);
            this.btnSolve.TabIndex = 0;
            this.btnSolve.Text = "Solve Puzzle";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);

            // 
            // lblSteps
            // 
            this.lblSteps.Location = new System.Drawing.Point(300, 70);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(200, 300);
            this.lblSteps.TabIndex = 1;
            this.lblSteps.Text = "Steps will appear here.";

            // 
            // pnlGoalState
            // 
            this.pnlGoalState.Location = new System.Drawing.Point(300, 400);
            this.pnlGoalState.Name = "pnlGoalState";
            this.pnlGoalState.Size = new System.Drawing.Size(200, 200);
            this.pnlGoalState.TabIndex = 2;
            this.pnlGoalState.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGoalState_Paint);

            // 
            // pnlPuzzle
            // 
            this.pnlPuzzle.Location = new System.Drawing.Point(20, 20);
            this.pnlPuzzle.Name = "pnlPuzzle";
            this.pnlPuzzle.Size = new System.Drawing.Size(200, 200);
            this.pnlPuzzle.TabIndex = 3;
            this.pnlPuzzle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPuzzle_Paint);

            // 
            // lblGoalState
            // 
            this.lblGoalState.Location = new System.Drawing.Point(300, 370);
            this.lblGoalState.Name = "lblGoalState";
            this.lblGoalState.Size = new System.Drawing.Size(100, 30);
            this.lblGoalState.TabIndex = 4;
            this.lblGoalState.Text = "Goal State:";

            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(20, 230);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(200, 100);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Press Solve to find the solution using different algorithms.";
            
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(540, 600);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.pnlGoalState);
            this.Controls.Add(this.pnlPuzzle);
            this.Controls.Add(this.lblGoalState);
            this.Controls.Add(this.lblInstructions);
            this.Name = "Form1";
            this.Text = "8-Puzzle Game";
            this.Load += new System.EventHandler(this.Form1_Load);
        }
    }
}