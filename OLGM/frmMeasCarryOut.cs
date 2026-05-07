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
    public partial class frmMeasCarryOut : Form
    {
        public frmMeasCarryOut()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString("yyyy年M月d日 HH:mm:ss");
        }

        // 橙色ラベルのパスを外部から設定するメソッド
        public void SetPaths(
            string analysisPath,
            string lanPath,
            string internalPath,
            string flowLANPath,
            string flowInternalPath)
        {
            lblAnalysisPath.Text     = analysisPath;
            lblLANPath.Text          = lanPath;
            lblInternalPath.Text     = internalPath;
            lblFlowLANPath.Text      = flowLANPath;
            lblFlowInternalPath.Text = flowInternalPath;
        }

        // アクセス不可パスがある場合に警告を表示
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
