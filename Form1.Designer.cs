namespace casaApplication
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.leftSideMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.helpCasa = new System.Windows.Forms.Label();
            this.settingButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientScreenButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.admScreenButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.billScreenButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.container = new System.Windows.Forms.Panel();
            this.leftSideMenu.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(497, 346);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 1;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // leftSideMenu
            // 
            this.leftSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.leftSideMenu.Controls.Add(this.titlePanel);
            this.leftSideMenu.Controls.Add(this.clientScreenButton);
            this.leftSideMenu.Controls.Add(this.admScreenButton);
            this.leftSideMenu.Controls.Add(this.billScreenButton);
            this.leftSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSideMenu.Location = new System.Drawing.Point(0, 0);
            this.leftSideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.leftSideMenu.Name = "leftSideMenu";
            this.leftSideMenu.Size = new System.Drawing.Size(200, 644);
            this.leftSideMenu.TabIndex = 3;
            this.leftSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.leftSideMenu_Paint);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.titlePanel.Controls.Add(this.helpCasa);
            this.titlePanel.Controls.Add(this.settingButton);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(200, 227);
            this.titlePanel.TabIndex = 5;
            // 
            // helpCasa
            // 
            this.helpCasa.AutoSize = true;
            this.helpCasa.BackColor = System.Drawing.Color.Transparent;
            this.helpCasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpCasa.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpCasa.ForeColor = System.Drawing.SystemColors.Window;
            this.helpCasa.Location = new System.Drawing.Point(51, 175);
            this.helpCasa.Name = "helpCasa";
            this.helpCasa.Size = new System.Drawing.Size(99, 26);
            this.helpCasa.TabIndex = 5;
            this.helpCasa.Text = "Help Casa";
            this.helpCasa.Click += new System.EventHandler(this.helpCasa_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.Transparent;
            this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
            this.settingButton.Location = new System.Drawing.Point(3, 3);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(44, 48);
            this.settingButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingButton.TabIndex = 10;
            this.settingButton.TabStop = false;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clientScreenButton
            // 
            this.clientScreenButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.clientScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.clientScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientScreenButton.BorderRadius = 0;
            this.clientScreenButton.ButtonText = "Client";
            this.clientScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientScreenButton.DisabledColor = System.Drawing.Color.Gray;
            this.clientScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientScreenButton.Iconcolor = System.Drawing.Color.Transparent;
            this.clientScreenButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("clientScreenButton.Iconimage")));
            this.clientScreenButton.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("clientScreenButton.Iconimage_right")));
            this.clientScreenButton.Iconimage_right_Selected = null;
            this.clientScreenButton.Iconimage_Selected = null;
            this.clientScreenButton.IconMarginLeft = 0;
            this.clientScreenButton.IconMarginRight = 0;
            this.clientScreenButton.IconRightVisible = false;
            this.clientScreenButton.IconRightZoom = 0D;
            this.clientScreenButton.IconVisible = true;
            this.clientScreenButton.IconZoom = 90D;
            this.clientScreenButton.IsTab = false;
            this.clientScreenButton.Location = new System.Drawing.Point(0, 227);
            this.clientScreenButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.clientScreenButton.Name = "clientScreenButton";
            this.clientScreenButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.clientScreenButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(5)))), ((int)(((byte)(53)))));
            this.clientScreenButton.OnHoverTextColor = System.Drawing.Color.White;
            this.clientScreenButton.selected = false;
            this.clientScreenButton.Size = new System.Drawing.Size(200, 55);
            this.clientScreenButton.TabIndex = 9;
            this.clientScreenButton.Text = "Client";
            this.clientScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientScreenButton.Textcolor = System.Drawing.Color.White;
            this.clientScreenButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientScreenButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // admScreenButton
            // 
            this.admScreenButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.admScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.admScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admScreenButton.BorderRadius = 0;
            this.admScreenButton.ButtonText = "Ad Management";
            this.admScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admScreenButton.DisabledColor = System.Drawing.Color.Gray;
            this.admScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admScreenButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.admScreenButton.Iconcolor = System.Drawing.Color.Transparent;
            this.admScreenButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("admScreenButton.Iconimage")));
            this.admScreenButton.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("admScreenButton.Iconimage_right")));
            this.admScreenButton.Iconimage_right_Selected = null;
            this.admScreenButton.Iconimage_Selected = null;
            this.admScreenButton.IconMarginLeft = 0;
            this.admScreenButton.IconMarginRight = 0;
            this.admScreenButton.IconRightVisible = false;
            this.admScreenButton.IconRightZoom = 0D;
            this.admScreenButton.IconVisible = true;
            this.admScreenButton.IconZoom = 90D;
            this.admScreenButton.IsTab = false;
            this.admScreenButton.Location = new System.Drawing.Point(0, 292);
            this.admScreenButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.admScreenButton.Name = "admScreenButton";
            this.admScreenButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.admScreenButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(5)))), ((int)(((byte)(53)))));
            this.admScreenButton.OnHoverTextColor = System.Drawing.Color.White;
            this.admScreenButton.selected = false;
            this.admScreenButton.Size = new System.Drawing.Size(200, 55);
            this.admScreenButton.TabIndex = 10;
            this.admScreenButton.Text = "Ad Management";
            this.admScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admScreenButton.Textcolor = System.Drawing.Color.White;
            this.admScreenButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admScreenButton.Click += new System.EventHandler(this.admScreenButton_Click);
            // 
            // billScreenButton
            // 
            this.billScreenButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.billScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.billScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.billScreenButton.BorderRadius = 0;
            this.billScreenButton.ButtonText = "Bill";
            this.billScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billScreenButton.DisabledColor = System.Drawing.Color.Gray;
            this.billScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billScreenButton.Iconcolor = System.Drawing.Color.Transparent;
            this.billScreenButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("billScreenButton.Iconimage")));
            this.billScreenButton.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("billScreenButton.Iconimage_right")));
            this.billScreenButton.Iconimage_right_Selected = null;
            this.billScreenButton.Iconimage_Selected = null;
            this.billScreenButton.IconMarginLeft = 0;
            this.billScreenButton.IconMarginRight = 0;
            this.billScreenButton.IconRightVisible = false;
            this.billScreenButton.IconRightZoom = 0D;
            this.billScreenButton.IconVisible = true;
            this.billScreenButton.IconZoom = 90D;
            this.billScreenButton.IsTab = false;
            this.billScreenButton.Location = new System.Drawing.Point(0, 357);
            this.billScreenButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.billScreenButton.Name = "billScreenButton";
            this.billScreenButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.billScreenButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(5)))), ((int)(((byte)(53)))));
            this.billScreenButton.OnHoverTextColor = System.Drawing.Color.White;
            this.billScreenButton.selected = false;
            this.billScreenButton.Size = new System.Drawing.Size(200, 55);
            this.billScreenButton.TabIndex = 11;
            this.billScreenButton.Text = "Bill";
            this.billScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billScreenButton.Textcolor = System.Drawing.Color.White;
            this.billScreenButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billScreenButton.Click += new System.EventHandler(this.billScreenButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.headerPanel.Controls.Add(this.pictureBox5);
            this.headerPanel.Controls.Add(this.pictureBox3);
            this.headerPanel.Controls.Add(this.pictureBox2);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(200, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(719, 75);
            this.headerPanel.TabIndex = 4;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(611, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(554, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(668, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(200, 75);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(719, 569);
            this.container.TabIndex = 5;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(919, 644);
            this.Controls.Add(this.container);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.leftSideMenu);
            this.Controls.Add(this.doubleBitmapControl1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.home_Paint);
            this.leftSideMenu.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.FlowLayoutPanel leftSideMenu;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox settingButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label helpCasa;
        private Bunifu.Framework.UI.BunifuFlatButton clientScreenButton;
        private Bunifu.Framework.UI.BunifuFlatButton admScreenButton;
        private Bunifu.Framework.UI.BunifuFlatButton billScreenButton;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

