namespace WindowsFormsApplication3
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            WindowsFormsApplication3.Shape shape1 = new WindowsFormsApplication3.Shape();
            WindowsFormsApplication3.Shape shape2 = new WindowsFormsApplication3.Shape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextFigure1 = new WindowsFormsApplication3.nextFigure();
            this.btnFinish = new System.Windows.Forms.Button();
            this.tetris1 = new WindowsFormsApplication3.Tetris();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPo = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.mstMeni = new System.Windows.Forms.MenuStrip();
            this.gAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeTetrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mstMeni.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1599, 904);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextFigure1);
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.tetris1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblP);
            this.panel1.Controls.Add(this.lblPlayer);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblPo);
            this.panel1.Controls.Add(this.lblT);
            this.panel1.Controls.Add(this.lblPoints);
            this.panel1.Controls.Add(this.mstMeni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 904);
            this.panel1.TabIndex = 1;
            // 
            // nextFigure1
            // 
            this.nextFigure1.Location = new System.Drawing.Point(53, 260);
            this.nextFigure1.Name = "nextFigure1";
            shape1.CurrentColor = System.Drawing.Color.Blue;
            shape1.CurrentPosition = new System.Drawing.Point(0, 0);
            shape1.CurrentShape = new System.Drawing.Point[] {
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(-1, 0),
        new System.Drawing.Point(1, 0)};
            shape1.IsRotatable = true;
            nextFigure.NextShape = shape1;
            this.nextFigure1.Size = new System.Drawing.Size(148, 150);
            this.nextFigure1.TabIndex = 21;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinish.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFinish.Font = new System.Drawing.Font("Linux Libertine Display G", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinish.Location = new System.Drawing.Point(553, 774);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(444, 80);
            this.btnFinish.TabIndex = 20;
            this.btnFinish.Text = "FINISH";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tetris1
            // 
            shape2.CurrentColor = System.Drawing.Color.Purple;
            shape2.CurrentPosition = new System.Drawing.Point(0, 0);
            shape2.CurrentShape = new System.Drawing.Point[] {
        new System.Drawing.Point(0, 0),
        new System.Drawing.Point(1, 0),
        new System.Drawing.Point(-1, 0),
        new System.Drawing.Point(0, 1),
        new System.Drawing.Point(0, -1)};
            shape2.IsRotatable = false;
            this.tetris1.CurrentShape = shape2;
            this.tetris1.Location = new System.Drawing.Point(553, 194);
            this.tetris1.Name = "tetris1";
            this.tetris1.Points = 0;
            this.tetris1.Size = new System.Drawing.Size(500, 500);
            this.tetris1.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(977, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 25);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Linux Libertine Display G", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(553, 45);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(444, 80);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "PAUSE";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 63);
            this.label5.TabIndex = 16;
            this.label5.Text = "NEXT FIGURE:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblP
            // 
            this.lblP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.DarkRed;
            this.lblP.Location = new System.Drawing.Point(12, 439);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(262, 63);
            this.lblP.TabIndex = 12;
            this.lblP.Text = "PLAYER:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPlayer.Font = new System.Drawing.Font("Linux Libertine Display G", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(22, 502);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(79, 61);
            this.lblPlayer.TabIndex = 13;
            this.lblPlayer.Text = "10";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTime.Font = new System.Drawing.Font("Linux Libertine Display G", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(22, 793);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 61);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "0s";
            // 
            // lblPo
            // 
            this.lblPo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPo.AutoSize = true;
            this.lblPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPo.Location = new System.Drawing.Point(12, 581);
            this.lblPo.Name = "lblPo";
            this.lblPo.Size = new System.Drawing.Size(250, 63);
            this.lblPo.TabIndex = 8;
            this.lblPo.Text = "POINTS:";
            // 
            // lblT
            // 
            this.lblT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.DarkRed;
            this.lblT.Location = new System.Drawing.Point(12, 730);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(176, 63);
            this.lblT.TabIndex = 10;
            this.lblT.Text = "TIME:";
            // 
            // lblPoints
            // 
            this.lblPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPoints.Font = new System.Drawing.Font("Linux Libertine Display G", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(22, 644);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(53, 61);
            this.lblPoints.TabIndex = 9;
            this.lblPoints.Text = "0";
            // 
            // mstMeni
            // 
            this.mstMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gAMEToolStripMenuItem});
            this.mstMeni.Location = new System.Drawing.Point(0, 0);
            this.mstMeni.Name = "mstMeni";
            this.mstMeni.Size = new System.Drawing.Size(1100, 24);
            this.mstMeni.TabIndex = 15;
            this.mstMeni.Text = "menuStrip1";
            // 
            // gAMEToolStripMenuItem
            // 
            this.gAMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeTetrisToolStripMenuItem,
            this.toolStripSeparator1,
            this.startNewGameToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.gAMEToolStripMenuItem.Name = "gAMEToolStripMenuItem";
            this.gAMEToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.gAMEToolStripMenuItem.Text = "GAME";
            // 
            // customizeTetrisToolStripMenuItem
            // 
            this.customizeTetrisToolStripMenuItem.Name = "customizeTetrisToolStripMenuItem";
            this.customizeTetrisToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.customizeTetrisToolStripMenuItem.Text = "Customize Tetris";
            this.customizeTetrisToolStripMenuItem.Click += new System.EventHandler(this.customizeTetrisToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.startNewGameToolStripMenuItem.Text = "Start new game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblRank);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 904);
            this.panel2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 285);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 576);
            this.listBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 63);
            this.label3.TabIndex = 14;
            this.label3.Text = "HIGH SCORE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Linux Libertine Display G", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 61);
            this.label4.TabIndex = 15;
            this.label4.Text = "10";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRank.Location = new System.Drawing.Point(14, 219);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(197, 63);
            this.lblRank.TabIndex = 1;
            this.lblRank.Text = "RANK:";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 904);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mstMeni;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mstMeni.ResumeLayout(false);
            this.mstMeni.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPo;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip mstMeni;
        private System.Windows.Forms.ToolStripMenuItem gAMEToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private Tetris tetris1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem customizeTetrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private nextFigure nextFigure1;
    }
}