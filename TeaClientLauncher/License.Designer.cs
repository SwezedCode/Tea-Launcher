namespace TeaClientLauncher
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.background = new System.Windows.Forms.Panel();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.howtoredeem = new MetroFramework.Controls.MetroLabel();
            this.activatebutton = new MetroFramework.Controls.MetroButton();
            this.licenseinput = new MetroFramework.Controls.MetroTextBox();
            this.licenseheader = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.errorLbl = new MetroFramework.Controls.MetroLabel();
            this.background.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.background.Controls.Add(this.cancelBtn);
            this.background.Controls.Add(this.metroLabel4);
            this.background.Controls.Add(this.howtoredeem);
            this.background.Controls.Add(this.activatebutton);
            this.background.Controls.Add(this.licenseinput);
            this.background.Controls.Add(this.licenseheader);
            this.background.Controls.Add(this.panel3);
            this.background.Controls.Add(this.errorLbl);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 451);
            this.background.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(674, 404);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(103, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel4.Location = new System.Drawing.Point(23, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(360, 171);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = resources.GetString("metroLabel4.Text");
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // howtoredeem
            // 
            this.howtoredeem.AutoSize = true;
            this.howtoredeem.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.howtoredeem.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.howtoredeem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.howtoredeem.Location = new System.Drawing.Point(23, 171);
            this.howtoredeem.Name = "howtoredeem";
            this.howtoredeem.Size = new System.Drawing.Size(229, 25);
            this.howtoredeem.TabIndex = 14;
            this.howtoredeem.Text = "How do I redeem license?";
            this.howtoredeem.UseCustomBackColor = true;
            this.howtoredeem.UseCustomForeColor = true;
            // 
            // activatebutton
            // 
            this.activatebutton.Location = new System.Drawing.Point(23, 96);
            this.activatebutton.Name = "activatebutton";
            this.activatebutton.Size = new System.Drawing.Size(103, 23);
            this.activatebutton.TabIndex = 13;
            this.activatebutton.Text = "Activate License";
            this.activatebutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.activatebutton.UseSelectable = true;
            this.activatebutton.Click += new System.EventHandler(this.activatebutton_Click);
            // 
            // licenseinput
            // 
            // 
            // 
            // 
            this.licenseinput.CustomButton.Image = null;
            this.licenseinput.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.licenseinput.CustomButton.Name = "";
            this.licenseinput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.licenseinput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.licenseinput.CustomButton.TabIndex = 1;
            this.licenseinput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.licenseinput.CustomButton.UseSelectable = true;
            this.licenseinput.CustomButton.Visible = false;
            this.licenseinput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.licenseinput.Lines = new string[0];
            this.licenseinput.Location = new System.Drawing.Point(23, 67);
            this.licenseinput.MaxLength = 32767;
            this.licenseinput.Name = "licenseinput";
            this.licenseinput.PasswordChar = '\0';
            this.licenseinput.PromptText = "Enter License";
            this.licenseinput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.licenseinput.SelectedText = "";
            this.licenseinput.SelectionLength = 0;
            this.licenseinput.SelectionStart = 0;
            this.licenseinput.ShortcutsEnabled = true;
            this.licenseinput.Size = new System.Drawing.Size(252, 23);
            this.licenseinput.Style = MetroFramework.MetroColorStyle.Green;
            this.licenseinput.TabIndex = 11;
            this.licenseinput.UseCustomBackColor = true;
            this.licenseinput.UseCustomForeColor = true;
            this.licenseinput.UseSelectable = true;
            this.licenseinput.WaterMark = "Enter License";
            this.licenseinput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.licenseinput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // licenseheader
            // 
            this.licenseheader.AutoSize = true;
            this.licenseheader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.licenseheader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.licenseheader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.licenseheader.Location = new System.Drawing.Point(23, 39);
            this.licenseheader.Name = "licenseheader";
            this.licenseheader.Size = new System.Drawing.Size(183, 25);
            this.licenseheader.TabIndex = 10;
            this.licenseheader.Text = "Redeem License for ";
            this.licenseheader.UseCustomBackColor = true;
            this.licenseheader.UseCustomForeColor = true;
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
            this.panel2.Location = new System.Drawing.Point(767, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 21);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
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
            this.metroLabel2.Visible = false;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLbl.Location = new System.Drawing.Point(23, 122);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 0);
            this.errorLbl.TabIndex = 6;
            this.errorLbl.UseCustomBackColor = true;
            this.errorLbl.UseCustomForeColor = true;
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "License";
            this.Text = "License";
            this.Load += new System.EventHandler(this.License_Load);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel errorLbl;
        private MetroFramework.Controls.MetroLabel licenseheader;
        private MetroFramework.Controls.MetroTextBox licenseinput;
        private MetroFramework.Controls.MetroButton activatebutton;
        private MetroFramework.Controls.MetroLabel howtoredeem;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton cancelBtn;
    }
}