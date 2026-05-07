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
    public partial class frmFileList : Form
    {
        public frmFileList()
        {
            InitializeComponent();
        }

        // 左リスト（対象取得）にファイルを追加
        public void AddAcquiredFile(int no, string filename, int step, DateTime lastModified, string fullPath)
        {
            var item = new ListViewItem(no.ToString());
            item.SubItems.Add(filename);
            item.SubItems.Add(step.ToString());
            item.SubItems.Add(lastModified.ToString("yyyy/MM/dd HH:mm:ss"));
            item.SubItems.Add(fullPath);
            lvLeft.Items.Add(item);
        }

        // 右リスト（対象解析）にファイルを追加し、カウント表示を更新
        public void AddAnalysisFile(int no, string filename, int step, DateTime lastModified, string fullPath)
        {
            var item = new ListViewItem(no.ToString());
            item.SubItems.Add(filename);
            item.SubItems.Add(step.ToString());
            item.SubItems.Add(lastModified.ToString("yyyy/MM/dd HH:mm:ss"));
            item.SubItems.Add(fullPath);
            lvRight.Items.Add(item);
            UpdateRightCount();
        }

        // 開始・終了ファイルパスをステータスに表示
        public void SetStatusPaths(string startFile, string endFile)
        {
            lblStatus2.Text = "開始ファイル: " + startFile;
            lblStatus3.Text = "終了ファイル: " + endFile;
        }

        // 両リストをクリア
        public void ClearAll()
        {
            lvLeft.Items.Clear();
            lvRight.Items.Clear();
            UpdateRightCount();
        }

        private void UpdateRightCount()
        {
            int total   = lvLeft.Items.Count;
            int matched = lvRight.Items.Count;
            lblRightTitle.Text = $"対象解析スペクトルファイル一覧  {matched}/ {total}";
        }
    }
}
