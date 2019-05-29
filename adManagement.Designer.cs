namespace casaApplication
{
    partial class AdManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdManagement));
            this.clientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientPanel.BackgroundImage")));
            this.clientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientPanel.Controls.Add(this.panel1);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.clientPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.clientPanel.GradientTopLeft = System.Drawing.Color.White;
            this.clientPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Quality = 10;
            this.clientPanel.Size = new System.Drawing.Size(719, 569);
            this.clientPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(618, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 103);
            this.panel1.TabIndex = 1;
            // 
            // adManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 569);
            this.Controls.Add(this.clientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adManagement";
            this.Text = "adManagement";
            this.Load += new System.EventHandler(this.adManagement_Load);
            this.clientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel clientPanel;
        private System.Windows.Forms.Panel panel1;
    }
}