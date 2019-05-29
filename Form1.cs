using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casaApplication
{
    public partial class home : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public home()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings settingForm = new Settings();
            settingForm.TopLevel = false;
            container.Controls.Add(settingForm);
            settingForm.Show();
        }

        private void helpCasa_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Paint(object sender, PaintEventArgs e)
        {
            //LinearGradientBrush brush = new LinearGradientBrush(this.container, Color.White, Color.Black, 90F);
            //e.Graphics.FillRectangle(brush, this.container);
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? ", "Attention", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void leftSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            admScreenButton.IconRightVisible = false;
            clientScreenButton.IconRightVisible = true;
            billScreenButton.IconRightVisible = false;


            clientScreenButton.Enabled = false;
            admScreenButton.Enabled = true;
            billScreenButton.Enabled = true;
            settingButton.Enabled = true;

            container.Controls.Clear();

            Client clientForm = new Client();
            clientForm.TopLevel = false;
            container.Controls.Add(clientForm);
            clientForm.Show();
        }

        private void admScreenButton_Click(object sender, EventArgs e)
        {
            admScreenButton.IconRightVisible = true;
            clientScreenButton.IconRightVisible = false;
            billScreenButton.IconRightVisible = false;

            clientScreenButton.Enabled = true;
            admScreenButton.Enabled = false;
            billScreenButton.Enabled = true;
            settingButton.Enabled = true;


            container.Controls.Clear();

            AdManagement adManagementForm = new AdManagement();
            adManagementForm.TopLevel = false;
            container.Controls.Add(adManagementForm);
            adManagementForm.Show();
        }

        private void billScreenButton_Click(object sender, EventArgs e)
        {
            admScreenButton.IconRightVisible = false;
            clientScreenButton.IconRightVisible = false;
            billScreenButton.IconRightVisible = true;

            container.Controls.Clear();

            Bill billForm = new Bill();
            billForm.TopLevel = false;
            container.Controls.Add(billForm);
            billForm.Show();

            clientScreenButton.Enabled = true;
            admScreenButton.Enabled = true;
            billScreenButton.Enabled = false;
            settingButton.Enabled = true;
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            admScreenButton.IconRightVisible = false;
            clientScreenButton.IconRightVisible = false;
            billScreenButton.IconRightVisible = false;


            clientScreenButton.Enabled = true;
            admScreenButton.Enabled = true;
            billScreenButton.Enabled = true;
            settingButton.Enabled = false;


            container.Controls.Clear();

            Settings settingForm = new Settings();
            settingForm.TopLevel = false;
            container.Controls.Add(settingForm);
            settingForm.Show();

        }
    }
}
