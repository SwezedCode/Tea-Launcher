namespace TeaClientLauncher
{
    partial class TeaMCv3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeaMCv3));
            this.background = new System.Windows.Forms.Panel();
            this.screenshots = new MetroFramework.Controls.MetroButton();
            this.features = new MetroFramework.Controls.MetroButton();
            this.productheader = new MetroFramework.Controls.MetroLabel();
            this.java = new MetroFramework.Controls.MetroButton();
            this.librariesheader = new MetroFramework.Controls.MetroLabel();
            this.os = new MetroFramework.Controls.MetroLabel();
            this.requireheader = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbutton = new MetroFramework.Controls.MetroButton();
            this.currencyLbl = new MetroFramework.Controls.MetroLabel();
            this.currency = new MetroFramework.Controls.MetroComboBox();
            this.price = new MetroFramework.Controls.MetroLabel();
            this.license_button = new MetroFramework.Controls.MetroButton();
            this.launch_or_purchase_button = new MetroFramework.Controls.MetroButton();
            this.title = new MetroFramework.Controls.MetroLabel();
            this.errorLbl = new MetroFramework.Controls.MetroLabel();
            this.productImg = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.background.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.background.Controls.Add(this.screenshots);
            this.background.Controls.Add(this.features);
            this.background.Controls.Add(this.productheader);
            this.background.Controls.Add(this.java);
            this.background.Controls.Add(this.librariesheader);
            this.background.Controls.Add(this.os);
            this.background.Controls.Add(this.requireheader);
            this.background.Controls.Add(this.panel1);
            this.background.Controls.Add(this.productImg);
            this.background.Controls.Add(this.panel3);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(801, 451);
            this.background.TabIndex = 4;
            // 
            // screenshots
            // 
            this.screenshots.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.screenshots.Location = new System.Drawing.Point(23, 354);
            this.screenshots.Name = "screenshots";
            this.screenshots.Size = new System.Drawing.Size(141, 23);
            this.screenshots.TabIndex = 18;
            this.screenshots.Text = "See Screenshots";
            this.screenshots.UseCustomBackColor = true;
            this.screenshots.UseCustomForeColor = true;
            this.screenshots.UseSelectable = true;
            this.screenshots.Click += new System.EventHandler(this.screenshots_Click);
            // 
            // features
            // 
            this.features.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.features.Location = new System.Drawing.Point(23, 325);
            this.features.Name = "features";
            this.features.Size = new System.Drawing.Size(141, 23);
            this.features.TabIndex = 17;
            this.features.Text = "See Features";
            this.features.UseCustomBackColor = true;
            this.features.UseCustomForeColor = true;
            this.features.UseSelectable = true;
            this.features.Click += new System.EventHandler(this.features_Click);
            // 
            // productheader
            // 
            this.productheader.AutoSize = true;
            this.productheader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.productheader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.productheader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.productheader.Location = new System.Drawing.Point(13, 297);
            this.productheader.Name = "productheader";
            this.productheader.Size = new System.Drawing.Size(186, 25);
            this.productheader.TabIndex = 16;
            this.productheader.Text = "Product Information";
            this.productheader.UseCustomBackColor = true;
            this.productheader.UseCustomForeColor = true;
            // 
            // java
            // 
            this.java.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.java.Location = new System.Drawing.Point(23, 245);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(141, 23);
            this.java.TabIndex = 15;
            this.java.Text = "Download Java 8 JRE";
            this.java.UseCustomBackColor = true;
            this.java.UseCustomForeColor = true;
            this.java.UseSelectable = true;
            this.java.Click += new System.EventHandler(this.java_Click_1);
            // 
            // librariesheader
            // 
            this.librariesheader.AutoSize = true;
            this.librariesheader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.librariesheader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.librariesheader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.librariesheader.Location = new System.Drawing.Point(13, 217);
            this.librariesheader.Name = "librariesheader";
            this.librariesheader.Size = new System.Drawing.Size(166, 25);
            this.librariesheader.TabIndex = 14;
            this.librariesheader.Text = "Libraries Required";
            this.librariesheader.UseCustomBackColor = true;
            this.librariesheader.UseCustomForeColor = true;
            // 
            // os
            // 
            this.os.AutoSize = true;
            this.os.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.os.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.os.Location = new System.Drawing.Point(13, 197);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(318, 19);
            this.os.TabIndex = 13;
            this.os.Text = "Operation System: Windows 7 or higher | 32/64bit";
            this.os.UseCustomBackColor = true;
            this.os.UseCustomForeColor = true;
            // 
            // requireheader
            // 
            this.requireheader.AutoSize = true;
            this.requireheader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.requireheader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.requireheader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.requireheader.Location = new System.Drawing.Point(13, 168);
            this.requireheader.Name = "requireheader";
            this.requireheader.Size = new System.Drawing.Size(180, 25);
            this.requireheader.TabIndex = 12;
            this.requireheader.Text = "System Information";
            this.requireheader.UseCustomBackColor = true;
            this.requireheader.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.currencyLbl);
            this.panel1.Controls.Add(this.currency);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.license_button);
            this.panel1.Controls.Add(this.launch_or_purchase_button);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.errorLbl);
            this.panel1.Location = new System.Drawing.Point(489, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 292);
            this.panel1.TabIndex = 11;
            // 
            // backbutton
            // 
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backbutton.Location = new System.Drawing.Point(233, 258);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 30);
            this.backbutton.TabIndex = 17;
            this.backbutton.Text = "Back";
            this.backbutton.UseCustomBackColor = true;
            this.backbutton.UseCustomForeColor = true;
            this.backbutton.UseSelectable = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click_1);
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.currencyLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currencyLbl.Location = new System.Drawing.Point(213, 6);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(91, 15);
            this.currencyLbl.TabIndex = 12;
            this.currencyLbl.Text = "Choose Currency";
            this.currencyLbl.UseCustomBackColor = true;
            this.currencyLbl.UseCustomForeColor = true;
            // 
            // currency
            // 
            this.currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.currency.FormattingEnabled = true;
            this.currency.ItemHeight = 23;
            this.currency.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "CAD",
            "AUD",
            "SEK",
            "RUBLE"});
            this.currency.Location = new System.Drawing.Point(215, 23);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(90, 29);
            this.currency.Style = MetroFramework.MetroColorStyle.Green;
            this.currency.TabIndex = 16;
            this.currency.Tag = "";
            this.currency.UseCustomBackColor = true;
            this.currency.UseCustomForeColor = true;
            this.currency.UseSelectable = true;
            this.currency.SelectionChangeCommitted += new System.EventHandler(this.currency_SelectionChangeCommitted_1);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.price.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.price.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.price.Location = new System.Drawing.Point(3, 28);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 0);
            this.price.TabIndex = 15;
            this.price.UseCustomBackColor = true;
            this.price.UseCustomForeColor = true;
            // 
            // license_button
            // 
            this.license_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.license_button.Location = new System.Drawing.Point(13, 94);
            this.license_button.Name = "license_button";
            this.license_button.Size = new System.Drawing.Size(286, 30);
            this.license_button.TabIndex = 14;
            this.license_button.Text = "Activate License";
            this.license_button.UseCustomBackColor = true;
            this.license_button.UseCustomForeColor = true;
            this.license_button.UseSelectable = true;
            this.license_button.Click += new System.EventHandler(this.license_button_Click_1);
            // 
            // launch_or_purchase_button
            // 
            this.launch_or_purchase_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.launch_or_purchase_button.Location = new System.Drawing.Point(13, 58);
            this.launch_or_purchase_button.Name = "launch_or_purchase_button";
            this.launch_or_purchase_button.Size = new System.Drawing.Size(286, 30);
            this.launch_or_purchase_button.Style = MetroFramework.MetroColorStyle.Green;
            this.launch_or_purchase_button.TabIndex = 13;
            this.launch_or_purchase_button.Text = "Purchase License";
            this.launch_or_purchase_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.launch_or_purchase_button.UseCustomBackColor = true;
            this.launch_or_purchase_button.UseSelectable = true;
            this.launch_or_purchase_button.Click += new System.EventHandler(this.launch_or_purchase_button_Click_1);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.title.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(3, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 0);
            this.title.TabIndex = 12;
            this.title.UseCustomBackColor = true;
            this.title.UseCustomForeColor = true;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLbl.Location = new System.Drawing.Point(13, 127);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 0);
            this.errorLbl.TabIndex = 6;
            this.errorLbl.UseCustomBackColor = true;
            this.errorLbl.UseCustomForeColor = true;
            // 
            // productImg
            // 
            this.productImg.Image = global::TeaClientLauncher.Properties.Resources.minecraft;
            this.productImg.Location = new System.Drawing.Point(0, 24);
            this.productImg.Name = "productImg";
            this.productImg.Size = new System.Drawing.Size(799, 135);
            this.productImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.productImg.TabIndex = 10;
            this.productImg.TabStop = false;
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
            this.panel2.Click += new System.EventHandler(this.panel2_Click_1);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter_1);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave_1);
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
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click_1);
            this.metroLabel2.MouseEnter += new System.EventHandler(this.metroLabel2_MouseEnter_1);
            this.metroLabel2.MouseLeave += new System.EventHandler(this.metroLabel2_MouseLeave_1);
            // 
            // TeaMCv3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeaMCv3";
            this.Text = "TeaMCv3";
            this.Load += new System.EventHandler(this.TeaMCv3_Load);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private MetroFramework.Controls.MetroButton screenshots;
        private MetroFramework.Controls.MetroButton features;
        private MetroFramework.Controls.MetroLabel productheader;
        private MetroFramework.Controls.MetroButton java;
        private MetroFramework.Controls.MetroLabel librariesheader;
        private MetroFramework.Controls.MetroLabel os;
        private MetroFramework.Controls.MetroLabel requireheader;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton backbutton;
        private MetroFramework.Controls.MetroLabel currencyLbl;
        private MetroFramework.Controls.MetroComboBox currency;
        private MetroFramework.Controls.MetroLabel price;
        private MetroFramework.Controls.MetroButton license_button;
        private MetroFramework.Controls.MetroButton launch_or_purchase_button;
        private MetroFramework.Controls.MetroLabel title;
        private System.Windows.Forms.PictureBox productImg;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel errorLbl;
    }
}