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
    public partial class frmOnLine : Form
    {
        public frmOnLine()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString("yyyy年M月d日 H:mm:ss");
        }

        /// <summary>各パネルのパスを設定します。</summary>
        public void SetPaths(
            string summaryLAN,  string summaryINT,
            string peakLAN,     string peakINT,
            string sys1ECAL,    string sys1FCAL,
            string sys2ECAL,    string sys2FCAL,
            string nuclide,     string trend,
            string disp,        string joydas,
            string peakTS)
        {
            lblSummaryLAN.Text  = summaryLAN;
            lblSummaryINT.Text  = summaryINT;
            lblPeakLAN.Text     = peakLAN;
            lblPeakINT.Text     = peakINT;
            lblSys1ECAL.Text    = sys1ECAL;
            lblSys1FCAL.Text    = sys1FCAL;
            lblSys2ECAL.Text    = sys2ECAL;
            lblSys2FCAL.Text    = sys2FCAL;
            lblNuclideFile.Text = nuclide;
            lblTrendFile.Text   = trend;
            lblDispFile.Text    = disp;
            lblJOYDASFile.Text  = joydas;
            lblPeakTSFile.Text  = peakTS;
        }

        /// <summary>アクセス不可警告の表示/非表示を切り替えます。</summary>
        public void SetWarningVisible(bool visible)
        {
            lblWarning.Visible = visible;
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
    }
}
