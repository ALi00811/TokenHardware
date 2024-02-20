using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterFace.Forms
{
    public partial class frmActivition : Form
    {
        public string Hid { get; } = Controller.getHid();
        public string Sid { get; set; }

        public frmActivition()
        {
            InitializeComponent();
            Sid = Controller.getSid(Hid);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var hash = new GetHash();
            txtLicense.Text = Convert.ToBase64String(hash.computeHash((Encoding.UTF8.GetBytes(Hid))));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActivition_Load(object sender, EventArgs e)
        {
            txtSID.Text = Sid;
        }
    }
}
