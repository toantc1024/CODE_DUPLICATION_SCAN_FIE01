namespace Paint
{
    partial class PaintApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.menubarStrip = new System.Windows.Forms.MenuStrip();
            this.toolUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menubarStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.drawingPanel.Location = new System.Drawing.Point(0, 36);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(600, 600);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDrawing);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ContinueDrawing);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EndDrawing);
            // 
            // menubarStrip
            // 
            this.menubarStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menubarStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menubarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUndo,
            this.toolRedo});
            this.menubarStrip.Location = new System.Drawing.Point(0, 0);
            this.menubarStrip.Name = "menubarStrip";
            this.menubarStrip.Size = new System.Drawing.Size(598, 33);
            this.menubarStrip.TabIndex = 1;
            this.menubarStrip.Text = "menuStrip1";
            // 
            // toolUndo
            // 
            this.toolUndo.Name = "toolUndo";
            this.toolUndo.Size = new System.Drawing.Size(68, 29);
            this.toolUndo.Text = "Undo";
            this.toolUndo.Click += new System.EventHandler(this.UndoDrawing);
            // 
            // toolRedo
            // 
            this.toolRedo.Name = "toolRedo";
            this.toolRedo.Size = new System.Drawing.Size(65, 29);
            this.toolRedo.Text = "Redo";
            this.toolRedo.Click += new System.EventHandler(this.RedoDrawing);
            // 
            // PaintApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(598, 634);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.menubarStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menubarStrip;
            this.Name = "PaintApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.menubarStrip.ResumeLayout(false);
            this.menubarStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.MenuStrip menubarStrip;
        private System.Windows.Forms.ToolStripMenuItem toolUndo;
        private System.Windows.Forms.ToolStripMenuItem toolRedo;
    }
}

