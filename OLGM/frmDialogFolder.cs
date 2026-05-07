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
    public partial class frmDialogFolder : Form
    {
        // 選択されたフォルダパス
        public string SelectedPath { get; private set; } = string.Empty;

        // 初期表示パス（オプション）
        public string InitialPath { get; set; } = string.Empty;

        public frmDialogFolder()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BuildTree();
        }

        // ドライブツリーを構築
        private void BuildTree()
        {
            tvFolders.Nodes.Clear();
            var root = new TreeNode("My computer") { Tag = string.Empty };
            tvFolders.Nodes.Add(root);

            foreach (var drive in System.IO.DriveInfo.GetDrives())
            {
                string label;
                try
                {
                    string vol = drive.IsReady && !string.IsNullOrEmpty(drive.VolumeLabel)
                                 ? drive.VolumeLabel + " " : string.Empty;
                    label = $"{vol}({drive.Name.TrimEnd('\\')})";
                }
                catch { label = $"({drive.Name.TrimEnd('\\')})"; }

                var node = new TreeNode(label) { Tag = drive.RootDirectory.FullName };
                node.Nodes.Add(new TreeNode("...") { Tag = null }); // 展開トリガ用ダミー
                root.Nodes.Add(node);
            }

            root.Expand();

            if (!string.IsNullOrEmpty(InitialPath))
                SelectedPath = InitialPath;
        }

        // ノード展開時に子フォルダを読み込む
        private void tvFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = e.Node;
            if (!(node.Tag is string path) || string.IsNullOrEmpty(path)) return;
            if (node.Nodes.Count != 1 || node.Nodes[0].Tag != null) return;

            node.Nodes.Clear();
            try
            {
                foreach (var dir in System.IO.Directory.GetDirectories(path))
                {
                    var child = new TreeNode(System.IO.Path.GetFileName(dir)) { Tag = dir };
                    child.Nodes.Add(new TreeNode("...") { Tag = null });
                    node.Nodes.Add(child);
                }
            }
            catch { /* アクセス不可はスキップ */ }
        }

        private void tvFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is string path && !string.IsNullOrEmpty(path))
                SelectedPath = path;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chkClipboard.Checked && !string.IsNullOrEmpty(SelectedPath))
            {
                string text = chkShortPath.Checked ? GetShortPath(SelectedPath) : SelectedPath;
                Clipboard.SetText(text);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // 8.3形式（短いパス）を取得
        private static string GetShortPath(string longPath)
        {
            var sb = new System.Text.StringBuilder(260);
            if (NativeMethods.GetShortPathName(longPath, sb, sb.Capacity) > 0)
                return sb.ToString();
            return longPath;
        }

        private static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            internal static extern int GetShortPathName(
                string lpszLongPath,
                System.Text.StringBuilder lpszShortPath,
                int cchBuffer);
        }
    }
}
