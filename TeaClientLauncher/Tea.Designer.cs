namespace TeaClientLauncher
{
    partial class Tea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tea));
            this.background = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsLbl = new MetroFramework.Controls.MetroLabel();
            this.question_1Lbl = new MetroFramework.Controls.MetroLabel();
            this.questionLbl = new MetroFramework.Controls.MetroLabel();
            this.welcomeLbl = new MetroFramework.Controls.MetroLabel();
            this.longPanel = new System.Windows.Forms.Panel();
            this.rightLbl = new MetroFramework.Controls.MetroLabel();
            this.supportPanel = new System.Windows.Forms.Panel();
            this.supportLbl = new MetroFramework.Controls.MetroLabel();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.newsLbl = new MetroFramework.Controls.MetroLabel();
            this.cheatPanel = new System.Windows.Forms.Panel();
            this.cheatLbl = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeLbl = new MetroFramework.Controls.MetroLabel();
            this.errorLbl = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.longPanel.SuspendLayout();
            this.supportPanel.SuspendLayout();
            this.newsPanel.SuspendLayout();
            this.cheatPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.background.Controls.Add(this.settingsPanel);
            this.background.Controls.Add(this.question_1Lbl);
            this.background.Controls.Add(this.questionLbl);
            this.background.Controls.Add(this.welcomeLbl);
            this.background.Controls.Add(this.longPanel);
            this.background.Controls.Add(this.newsPanel);
            this.background.Controls.Add(this.cheatPanel);
            this.background.Controls.Add(this.panel3);
            this.background.Controls.Add(this.homePanel);
            this.background.Controls.Add(this.errorLbl);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 451);
            this.background.TabIndex = 1;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.settingsPanel.Controls.Add(this.settingsLbl);
            this.settingsPanel.Location = new System.Drawing.Point(0, 119);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(117, 33);
            this.settingsPanel.TabIndex = 16;
            this.settingsPanel.Click += new System.EventHandler(this.settingsPanel_Click);
            this.settingsPanel.MouseEnter += new System.EventHandler(this.settingsPanel_MouseEnter);
            this.settingsPanel.MouseLeave += new System.EventHandler(this.settingsPanel_MouseLeave);
            // 
            // settingsLbl
            // 
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.settingsLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.settingsLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsLbl.Location = new System.Drawing.Point(11, 4);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(71, 25);
            this.settingsLbl.TabIndex = 9;
            this.settingsLbl.Text = "Settings";
            this.settingsLbl.UseCustomBackColor = true;
            this.settingsLbl.UseCustomForeColor = true;
            this.settingsLbl.Click += new System.EventHandler(this.settingsLbl_Click);
            this.settingsLbl.MouseEnter += new System.EventHandler(this.settingsLbl_MouseEnter);
            this.settingsLbl.MouseLeave += new System.EventHandler(this.settingsLbl_MouseLeave);
            // 
            // question_1Lbl
            // 
            this.question_1Lbl.AutoSize = true;
            this.question_1Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.question_1Lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.question_1Lbl.Location = new System.Drawing.Point(128, 85);
            this.question_1Lbl.Name = "question_1Lbl";
            this.question_1Lbl.Size = new System.Drawing.Size(649, 38);
            this.question_1Lbl.TabIndex = 15;
            this.question_1Lbl.Text = "Tea Launcher is a application developed by Swezed. It\'s made for launching and pu" +
    "rchasing the products \r\nthat we sell.";
            this.question_1Lbl.UseCustomBackColor = true;
            this.question_1Lbl.UseCustomForeColor = true;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.questionLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.questionLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.questionLbl.Location = new System.Drawing.Point(126, 58);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(120, 25);
            this.questionLbl.TabIndex = 14;
            this.questionLbl.Text = "What is this?";
            this.questionLbl.UseCustomBackColor = true;
            this.questionLbl.UseCustomForeColor = true;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.welcomeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomeLbl.Location = new System.Drawing.Point(123, 25);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(100, 19);
            this.welcomeLbl.TabIndex = 13;
            this.welcomeLbl.Text = "Welcome back ";
            this.welcomeLbl.UseCustomBackColor = true;
            this.welcomeLbl.UseCustomForeColor = true;
            // 
            // longPanel
            // 
            this.longPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.longPanel.Controls.Add(this.rightLbl);
            this.longPanel.Controls.Add(this.supportPanel);
            this.longPanel.Location = new System.Drawing.Point(0, 152);
            this.longPanel.Name = "longPanel";
            this.longPanel.Size = new System.Drawing.Size(117, 299);
            this.longPanel.TabIndex = 12;
            // 
            // rightLbl
            // 
            this.rightLbl.AutoSize = true;
            this.rightLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rightLbl.Location = new System.Drawing.Point(0, 278);
            this.rightLbl.Name = "rightLbl";
            this.rightLbl.Size = new System.Drawing.Size(115, 19);
            this.rightLbl.TabIndex = 0;
            this.rightLbl.Text = "© Swezed Studios";
            this.rightLbl.UseCustomBackColor = true;
            this.rightLbl.UseCustomForeColor = true;
            // 
            // supportPanel
            // 
            this.supportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.supportPanel.Controls.Add(this.supportLbl);
            this.supportPanel.Location = new System.Drawing.Point(0, 0);
            this.supportPanel.Name = "supportPanel";
            this.supportPanel.Size = new System.Drawing.Size(117, 33);
            this.supportPanel.TabIndex = 11;
            this.supportPanel.Click += new System.EventHandler(this.supportPanel_Click);
            this.supportPanel.MouseEnter += new System.EventHandler(this.supportPanel_MouseEnter);
            this.supportPanel.MouseLeave += new System.EventHandler(this.supportPanel_MouseLeave);
            // 
            // supportLbl
            // 
            this.supportLbl.AutoSize = true;
            this.supportLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.supportLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.supportLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.supportLbl.Location = new System.Drawing.Point(11, 4);
            this.supportLbl.Name = "supportLbl";
            this.supportLbl.Size = new System.Drawing.Size(47, 25);
            this.supportLbl.TabIndex = 9;
            this.supportLbl.Text = "Help";
            this.supportLbl.UseCustomBackColor = true;
            this.supportLbl.UseCustomForeColor = true;
            this.supportLbl.Click += new System.EventHandler(this.supportLbl_Click);
            this.supportLbl.MouseEnter += new System.EventHandler(this.supportLbl_MouseEnter);
            this.supportLbl.MouseLeave += new System.EventHandler(this.supportLbl_MouseLeave);
            // 
            // newsPanel
            // 
            this.newsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.newsPanel.Controls.Add(this.newsLbl);
            this.newsPanel.Location = new System.Drawing.Point(0, 54);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(117, 33);
            this.newsPanel.TabIndex = 10;
            this.newsPanel.Click += new System.EventHandler(this.newsPanel_Click);
            this.newsPanel.MouseEnter += new System.EventHandler(this.newsPanel_MouseEnter);
            this.newsPanel.MouseLeave += new System.EventHandler(this.newsPanel_MouseLeave);
            // 
            // newsLbl
            // 
            this.newsLbl.AutoSize = true;
            this.newsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.newsLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.newsLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newsLbl.Location = new System.Drawing.Point(11, 4);
            this.newsLbl.Name = "newsLbl";
            this.newsLbl.Size = new System.Drawing.Size(53, 25);
            this.newsLbl.TabIndex = 9;
            this.newsLbl.Text = "News";
            this.newsLbl.UseCustomBackColor = true;
            this.newsLbl.UseCustomForeColor = true;
            this.newsLbl.Click += new System.EventHandler(this.newsLbl_Click);
            this.newsLbl.MouseEnter += new System.EventHandler(this.newsLbl_MouseEnter);
            this.newsLbl.MouseLeave += new System.EventHandler(this.newsLbl_MouseLeave);
            // 
            // cheatPanel
            // 
            this.cheatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cheatPanel.Controls.Add(this.cheatLbl);
            this.cheatPanel.Location = new System.Drawing.Point(0, 87);
            this.cheatPanel.Name = "cheatPanel";
            this.cheatPanel.Size = new System.Drawing.Size(117, 33);
            this.cheatPanel.TabIndex = 10;
            this.cheatPanel.Click += new System.EventHandler(this.cheatPanel_Click);
            this.cheatPanel.MouseEnter += new System.EventHandler(this.cheatPanel_MouseEnter);
            this.cheatPanel.MouseLeave += new System.EventHandler(this.cheatPanel_MouseLeave);
            // 
            // cheatLbl
            // 
            this.cheatLbl.AutoSize = true;
            this.cheatLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cheatLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.cheatLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cheatLbl.Location = new System.Drawing.Point(11, 4);
            this.cheatLbl.Name = "cheatLbl";
            this.cheatLbl.Size = new System.Drawing.Size(63, 25);
            this.cheatLbl.TabIndex = 9;
            this.cheatLbl.Text = "Cheats";
            this.cheatLbl.UseCustomBackColor = true;
            this.cheatLbl.UseCustomForeColor = true;
            this.cheatLbl.Click += new System.EventHandler(this.cheatLbl_Click);
            this.cheatLbl.MouseEnter += new System.EventHandler(this.cheatLbl_MouseEnter);
            this.cheatLbl.MouseLeave += new System.EventHandler(this.cheatLbl_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Controls.Add(this.metroLabel3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 20);
            this.panel3.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel1.Location = new System.Drawing.Point(122, -1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "BETA";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel3.Location = new System.Drawing.Point(42, -1);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Tea Launcher";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeaClientLauncher.Properties.Resources.tea_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(767, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 21);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(7, -5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(20, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "x";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            this.metroLabel2.MouseEnter += new System.EventHandler(this.metroLabel2_MouseEnter);
            this.metroLabel2.MouseLeave += new System.EventHandler(this.metroLabel2_MouseLeave);
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.homePanel.Controls.Add(this.homeLbl);
            this.homePanel.Location = new System.Drawing.Point(0, 21);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(117, 33);
            this.homePanel.TabIndex = 8;
            // 
            // homeLbl
            // 
            this.homeLbl.AutoSize = true;
            this.homeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.homeLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.homeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(227)))), ((int)(((byte)(99)))));
            this.homeLbl.Location = new System.Drawing.Point(11, 4);
            this.homeLbl.Name = "homeLbl";
            this.homeLbl.Size = new System.Drawing.Size(58, 25);
            this.homeLbl.TabIndex = 9;
            this.homeLbl.Text = "Home";
            this.homeLbl.UseCustomBackColor = true;
            this.homeLbl.UseCustomForeColor = true;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLbl.Location = new System.Drawing.Point(272, 253);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 0);
            this.errorLbl.TabIndex = 6;
            this.errorLbl.UseCustomBackColor = true;
            this.errorLbl.UseCustomForeColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tea";
            this.Text = "Tea";
            this.Load += new System.EventHandler(this.Tea_Load);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.longPanel.ResumeLayout(false);
            this.longPanel.PerformLayout();
            this.supportPanel.ResumeLayout(false);
            this.supportPanel.PerformLayout();
            this.newsPanel.ResumeLayout(false);
            this.newsPanel.PerformLayout();
            this.cheatPanel.ResumeLayout(false);
            this.cheatPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel errorLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel homePanel;
        private MetroFramework.Controls.MetroLabel homeLbl;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel cheatLbl;
        private System.Windows.Forms.Panel cheatPanel;
        private System.Windows.Forms.Panel supportPanel;
        private MetroFramework.Controls.MetroLabel supportLbl;
        private System.Windows.Forms.Panel newsPanel;
        private MetroFramework.Controls.MetroLabel newsLbl;
        private System.Windows.Forms.Panel longPanel;
        private MetroFramework.Controls.MetroLabel rightLbl;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel welcomeLbl;
        private MetroFramework.Controls.MetroLabel questionLbl;
        private MetroFramework.Controls.MetroLabel question_1Lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel settingsPanel;
        private MetroFramework.Controls.MetroLabel settingsLbl;
    }
}