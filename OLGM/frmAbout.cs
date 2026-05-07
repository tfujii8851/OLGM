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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();

            lblProductName.Text  = "Online Gamma-ray Monitor (Measurement)";
            lblCopyright.Text    = "Copyright 2003 (C) OHYO KOKEN KOGYO CO., LTD.";
            c1Label3.Text        = "製造元";
            lblCompanyName.Text  = "応用光研工業株式会社　計測機器部";
            lblDiscription.Text  = "常陽　オンラインγ線モニタの制御ソフトの製作";
            lblVersion.Text      = "Version 1.00  Build 18";
            lblDisclaimer.Text   = "本製品は契約書に従ってご使用下さい。" +
                                   "使用範囲を超えた複製物の使用及び配布はご遠慮願いますのでご注意下さい。";
        }

        private void c1Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
