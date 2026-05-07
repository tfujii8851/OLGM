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
    public partial class frmIndicateFlowrate : Form
    {
        public frmIndicateFlowrate()
        {
            InitializeComponent();
        }

        // 流量値を更新する（外部から呼び出し）
        public void SetFlowrate(double value)
        {
            lblFlowrate.Text = $"{value:F2} [L/min]";
        }
    }
}
