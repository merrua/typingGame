namespace TypingGame
{
    partial class TypingGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypingGame));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctValue = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultylabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.totalLabel,
            this.accuracyLabel,
            this.difficultylabel,
            this.difficultyProgressBar});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // correctValue
            // 
            resources.ApplyResources(this.correctValue, "correctValue");
            this.correctValue.Name = "correctValue";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            resources.ApplyResources(this.correctLabel, "correctLabel");
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            resources.ApplyResources(this.missedLabel, "missedLabel");
            // 
            // totalLabel
            // 
            this.totalLabel.Name = "totalLabel";
            resources.ApplyResources(this.totalLabel, "totalLabel");
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Name = "accuracyLabel";
            resources.ApplyResources(this.accuracyLabel, "accuracyLabel");
            // 
            // difficultylabel
            // 
            resources.ApplyResources(this.difficultylabel, "difficultylabel");
            this.difficultylabel.Name = "difficultylabel";
            this.difficultylabel.Spring = true;
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            resources.ApplyResources(this.difficultyProgressBar, "difficultyProgressBar");
            // 
            // TypingGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.correctValue);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypingGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypingGame_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label correctValue;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalLabel;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel difficultylabel;
        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
    }
}

