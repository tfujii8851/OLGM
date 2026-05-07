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
    public partial class frmValve : Form
    {
        public frmValve()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString("yyyy年M月d日 HH:mm:ss");
        }

        // パネルSW側インジケータ更新 (isOpen=true:開/false:閉)
        // svIndex: 1-8
        public void SetPanelSWStatus(int svIndex, bool isOpen)
        {
            var btnOpen  = GetPanelOpenButton(svIndex);
            var btnClose = GetPanelCloseButton(svIndex);
            if (btnOpen  == null || btnClose == null) return;
            btnOpen.BackColor  = isOpen ? System.Drawing.Color.Crimson : System.Drawing.Color.DarkGray;
            btnClose.BackColor = isOpen ? System.Drawing.Color.DarkGray : System.Drawing.Color.Green;
        }

        // 遠隔操作側状態インジケータ更新
        public void SetRemoteStatus(int svIndex, bool isOpen)
        {
            var btnOpen  = GetRemoteOpenButton(svIndex);
            var btnClose = GetRemoteCloseButton(svIndex);
            if (btnOpen  == null || btnClose == null) return;
            btnOpen.BackColor  = isOpen ? System.Drawing.Color.Crimson : System.Drawing.Color.DarkGray;
            btnClose.BackColor = isOpen ? System.Drawing.Color.DarkGray : System.Drawing.Color.Green;
        }

        // ── イベントハンドラ ──────────────────────────────────
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // 各SVの開指示チェック状態を読み取り実行
            var checks = new[] { chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8 };
            for (int i = 0; i < checks.Length; i++)
            {
                bool open = (checks[i].Value is bool b && b) || (checks[i].Value is string s && s == "1");
                SetRemoteStatus(i + 1, open);
            }
        }

        // ── ヘルパー ──────────────────────────────────────────
        private C1.Win.C1Input.C1Button GetPanelOpenButton(int n)
        {
            switch (n)
            {
                case 1: return btnP1Open;  case 2: return btnP2Open;  case 3: return btnP3Open;
                case 4: return btnP4Open;  case 5: return btnP5Open;  case 6: return btnP6Open;
                case 7: return btnP7Open;  case 8: return btnP8Open;  default: return null;
            }
        }

        private C1.Win.C1Input.C1Button GetPanelCloseButton(int n)
        {
            switch (n)
            {
                case 1: return btnP1Close;  case 2: return btnP2Close;  case 3: return btnP3Close;
                case 4: return btnP4Close;  case 5: return btnP5Close;  case 6: return btnP6Close;
                case 7: return btnP7Close;  case 8: return btnP8Close;  default: return null;
            }
        }

        private C1.Win.C1Input.C1Button GetRemoteOpenButton(int n)
        {
            switch (n)
            {
                case 1: return btnR1Open;  case 2: return btnR2Open;  case 3: return btnR3Open;
                case 4: return btnR4Open;  case 5: return btnR5Open;  case 6: return btnR6Open;
                case 7: return btnR7Open;  case 8: return btnR8Open;  default: return null;
            }
        }

        private C1.Win.C1Input.C1Button GetRemoteCloseButton(int n)
        {
            switch (n)
            {
                case 1: return btnR1Close;  case 2: return btnR2Close;  case 3: return btnR3Close;
                case 4: return btnR4Close;  case 5: return btnR5Close;  case 6: return btnR6Close;
                case 7: return btnR7Close;  case 8: return btnR8Close;  default: return null;
            }
        }
        // ── ヘルパー: 遠隔操作中央行の設定 ──────────────────
        private void SetupRemoteRow(
            C1.Win.C1Input.C1Label lbl,
            C1.Win.C1Input.C1CheckBox chk,
            C1.Win.C1Input.C1Button btnOpen,
            C1.Win.C1Input.C1Button btnClose,
            string svName, int tabBase, int y)
        {
            var font9 = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lbl.Font = font9;
            lbl.Location = new System.Drawing.Point(5, y);
            lbl.Name = "lblR" + svName.Replace(" ", "");
            lbl.Size = new System.Drawing.Size(40, 18);
            lbl.Tag = null;
            lbl.Text = svName;
            lbl.TabIndex = tabBase;

            chk.Font = font9;
            chk.Location = new System.Drawing.Point(55, y);
            chk.Name = "chk" + svName.Replace(" ", "");
            chk.Size = new System.Drawing.Size(70, 18);
            chk.Tag = null;
            chk.Text = "開";
            chk.Value = null;
            chk.TabIndex = tabBase + 1;

            btnOpen.BackColor = System.Drawing.Color.Crimson;
            btnOpen.Font = font9;
            btnOpen.ForeColor = System.Drawing.Color.White;
            btnOpen.Location = new System.Drawing.Point(150, y - 1);
            btnOpen.Name = "btnR" + svName.Replace(" ", "") + "Open";
            btnOpen.Size = new System.Drawing.Size(33, 20);
            btnOpen.Tag = null;
            btnOpen.Text = "開";
            btnOpen.TabIndex = tabBase + 2;

            btnClose.BackColor = System.Drawing.Color.Green;
            btnClose.Font = font9;
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(187, y - 1);
            btnClose.Name = "btnR" + svName.Replace(" ", "") + "Close";
            btnClose.Size = new System.Drawing.Size(33, 20);
            btnClose.Tag = null;
            btnClose.Text = "閉";
            btnClose.TabIndex = tabBase + 3;
        }

        // ── ヘルパー: パネルSW左行の設定 ────────────────────
        private void SetupPanelRow(
            C1.Win.C1Input.C1Label lbl,
            C1.Win.C1Input.C1Button btnOpen,
            C1.Win.C1Input.C1Button btnClose,
            string svName, int tabBase, int y)
        {
            var font9 = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lbl.Font = font9;
            lbl.Location = new System.Drawing.Point(5, y);
            lbl.Name = "lbl" + svName.Replace(" ", "");
            lbl.Size = new System.Drawing.Size(34, 18);
            lbl.Tag = null;
            lbl.Text = svName;
            lbl.TabIndex = tabBase;

            btnOpen.BackColor = System.Drawing.Color.Crimson;
            btnOpen.Font = font9;
            btnOpen.ForeColor = System.Drawing.Color.White;
            btnOpen.Location = new System.Drawing.Point(42, y - 1);
            btnOpen.Name = "btn" + svName.Replace(" ", "") + "Open";
            btnOpen.Size = new System.Drawing.Size(33, 20);
            btnOpen.Tag = null;
            btnOpen.Text = "開";
            btnOpen.TabIndex = tabBase + 1;

            btnClose.BackColor = System.Drawing.Color.Green;
            btnClose.Font = font9;
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(78, y - 1);
            btnClose.Name = "btn" + svName.Replace(" ", "") + "Close";
            btnClose.Size = new System.Drawing.Size(33, 20);
            btnClose.Tag = null;
            btnClose.Text = "閉";
            btnClose.TabIndex = tabBase + 2;
        }
    }
}
