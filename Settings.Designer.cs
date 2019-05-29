namespace casaApplication
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.settingsPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.optionsBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox3 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.databaseBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.schemaInput = new Bunifu.Framework.UI.BunifuTextbox();
            this.schemaText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.settingsPanel.SuspendLayout();
            this.optionsBox.SuspendLayout();
            this.databaseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsPanel.BackgroundImage")));
            this.settingsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsPanel.Controls.Add(this.optionsBox);
            this.settingsPanel.Controls.Add(this.databaseBox);
            this.settingsPanel.Controls.Add(this.panel1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.settingsPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.settingsPanel.GradientTopLeft = System.Drawing.Color.White;
            this.settingsPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Quality = 10;
            this.settingsPanel.Size = new System.Drawing.Size(719, 569);
            this.settingsPanel.TabIndex = 0;
            // 
            // optionsBox
            // 
            this.optionsBox.BackColor = System.Drawing.Color.Transparent;
            this.optionsBox.Controls.Add(this.comboBox1);
            this.optionsBox.Controls.Add(this.bunifuCustomLabel3);
            this.optionsBox.Controls.Add(this.bunifuCustomLabel2);
            this.optionsBox.Controls.Add(this.bunifuCustomLabel1);
            this.optionsBox.Controls.Add(this.bunifuCheckbox3);
            this.optionsBox.Controls.Add(this.bunifuCheckbox2);
            this.optionsBox.Controls.Add(this.bunifuCheckbox1);
            this.optionsBox.Controls.Add(this.bunifuFlatButton1);
            this.optionsBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBox.Location = new System.Drawing.Point(12, 225);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(695, 179);
            this.optionsBox.TabIndex = 2;
            this.optionsBox.TabStop = false;
            this.optionsBox.Text = "Options";
            this.optionsBox.Enter += new System.EventHandler(this.optionsBox_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(92, 134);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(323, 14);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Au démarrage de l\'application lancez la fenêtre:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(92, 93);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(341, 14);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Advertissement avant la fermeture de l\'application";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(92, 51);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(243, 14);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Advertissement avant la suppresion";
            // 
            // bunifuCheckbox3
            // 
            this.bunifuCheckbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox3.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuCheckbox3.Checked = true;
            this.bunifuCheckbox3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox3.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox3.Location = new System.Drawing.Point(44, 130);
            this.bunifuCheckbox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuCheckbox3.Name = "bunifuCheckbox3";
            this.bunifuCheckbox3.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox3.TabIndex = 5;
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(44, 89);
            this.bunifuCheckbox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 4;
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(44, 47);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 3;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Browse";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(837, 44);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(168, 59);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Browse";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // databaseBox
            // 
            this.databaseBox.BackColor = System.Drawing.Color.Transparent;
            this.databaseBox.Controls.Add(this.browseButton);
            this.databaseBox.Controls.Add(this.schemaInput);
            this.databaseBox.Controls.Add(this.schemaText);
            this.databaseBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseBox.Location = new System.Drawing.Point(12, 49);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(695, 100);
            this.databaseBox.TabIndex = 0;
            this.databaseBox.TabStop = false;
            this.databaseBox.Text = "Database";
            // 
            // browseButton
            // 
            this.browseButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.browseButton.BackColor = System.Drawing.Color.Maroon;
            this.browseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browseButton.BorderRadius = 0;
            this.browseButton.ButtonText = "Browse";
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.DisabledColor = System.Drawing.Color.Gray;
            this.browseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.browseButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("browseButton.Iconimage")));
            this.browseButton.Iconimage_right = null;
            this.browseButton.Iconimage_right_Selected = null;
            this.browseButton.Iconimage_Selected = null;
            this.browseButton.IconMarginLeft = 0;
            this.browseButton.IconMarginRight = 0;
            this.browseButton.IconRightVisible = true;
            this.browseButton.IconRightZoom = 0D;
            this.browseButton.IconVisible = true;
            this.browseButton.IconZoom = 90D;
            this.browseButton.IsTab = false;
            this.browseButton.Location = new System.Drawing.Point(558, 36);
            this.browseButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Normalcolor = System.Drawing.Color.Maroon;
            this.browseButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.browseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.browseButton.selected = false;
            this.browseButton.Size = new System.Drawing.Size(112, 48);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseButton.Textcolor = System.Drawing.Color.White;
            this.browseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // schemaInput
            // 
            this.schemaInput.BackColor = System.Drawing.Color.Silver;
            this.schemaInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("schemaInput.BackgroundImage")));
            this.schemaInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schemaInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.schemaInput.Icon = ((System.Drawing.Image)(resources.GetObject("schemaInput.Icon")));
            this.schemaInput.Location = new System.Drawing.Point(111, 36);
            this.schemaInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.schemaInput.Name = "schemaInput";
            this.schemaInput.Size = new System.Drawing.Size(423, 42);
            this.schemaInput.TabIndex = 1;
            this.schemaInput.text = "";
            // 
            // schemaText
            // 
            this.schemaText.AutoSize = true;
            this.schemaText.Location = new System.Drawing.Point(30, 47);
            this.schemaText.Name = "schemaText";
            this.schemaText.Size = new System.Drawing.Size(66, 16);
            this.schemaText.TabIndex = 0;
            this.schemaText.Text = "Schema";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(613, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 87);
            this.panel1.TabIndex = 1;
            // 
            // browseFileDialog
            // 
            this.browseFileDialog.FileName = "browseFileDialog";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 569);
            this.Controls.Add(this.settingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Form2";
            this.settingsPanel.ResumeLayout(false);
            this.optionsBox.ResumeLayout(false);
            this.optionsBox.PerformLayout();
            this.databaseBox.ResumeLayout(false);
            this.databaseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel settingsPanel;
        private System.Windows.Forms.GroupBox databaseBox;
        private System.Windows.Forms.Label schemaText;
        private Bunifu.Framework.UI.BunifuTextbox schemaInput;
        private Bunifu.Framework.UI.BunifuFlatButton browseButton;
        private System.Windows.Forms.OpenFileDialog browseFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox optionsBox;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox3;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}