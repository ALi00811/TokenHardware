using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterFace.Forms;

namespace UserInterFace
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void toolRegister_Click(object sender, EventArgs e)
        {
            new frmActivition().ShowDialog();
        }
    }
}
