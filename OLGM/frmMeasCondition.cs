using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLGM
{
    public partial class frmMeasCondition : Form
    {
        public frmMeasCondition()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            txtCycleName.Text = "";
            txtStartNum.Text  = "00001";
            chkSave1.Value    = true;
            lblFolder1.Text   = "";
            chkSave2.Value    = true;
            lblFolder2.Text   = "";
            chkSave3.Value    = true;
            lblFolder3.Text   = "";
        }

        private void btnRef1_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.SelectedPath = lblFolder1.Text;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    lblFolder1.Text = dlg.SelectedPath;
            }
        }

        private void btnRef2_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.SelectedPath = lblFolder2.Text;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    lblFolder2.Text = dlg.SelectedPath;
            }
        }

        private void btnRef3_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.SelectedPath = lblFolder3.Text;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    lblFolder3.Text = dlg.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}
