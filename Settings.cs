using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casaApplication
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = browseFileDialog.ShowDialog(); // Show the dialog.
            string file = browseFileDialog.FileName;
            schemaInput.text = browseFileDialog.FileName;
            schemaInput.Enabled = false;
        }

        private void optionsBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
