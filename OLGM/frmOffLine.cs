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
    public partial class frmOffLine : Form
    {
        public frmOffLine()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString("yyyy年M月d日 H:mm:ss");
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnQUALT_Click(object sender, EventArgs e)
        {
        }

        private void btnQUANT_Click(object sender, EventArgs e)
        {
        }

        private void btnECAL_Click(object sender, EventArgs e)
        {
        }

        private void btnFCAL_Click(object sender, EventArgs e)
        {
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title  = "ピークサーチ作業ファイルの選択";
                dlg.Filter = "DATファイル (*.DAT)|*.DAT|すべてのファイル (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lblPeakFilePath.Text = dlg.FileName;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}
