namespace OLGM
{
    partial class frmDialogFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle     = new C1.Win.C1Input.C1Label();
            this.tvFolders    = new System.Windows.Forms.TreeView();
            this.btnOK        = new C1.Win.C1Input.C1Button();
            this.btnCancel    = new C1.Win.C1Input.C1Button();
            this.chkShortPath = new System.Windows.Forms.CheckBox();
            this.chkClipboard = new System.Windows.Forms.CheckBox();

            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTitle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(8, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Tag = null;
            this.lblTitle.Text = "指定フォルダ";
            //
            // tvFolders
            //
            this.tvFolders.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tvFolders.Location = new System.Drawing.Point(8, 28);
            this.tvFolders.Name = "tvFolders";
            this.tvFolders.Size = new System.Drawing.Size(370, 248);
            this.tvFolders.TabIndex = 1;
            this.tvFolders.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvFolders_BeforeExpand);
            this.tvFolders.AfterSelect  += new System.Windows.Forms.TreeViewEventHandler(this.tvFolders_AfterSelect);
            //
            // btnOK
            //
            this.btnOK.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOK.Location = new System.Drawing.Point(386, 28);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Tag = null;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            // btnCancel
            //
            this.btnCancel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(386, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Tag = null;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // chkShortPath
            //
            this.chkShortPath.AutoSize = true;
            this.chkShortPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkShortPath.Location = new System.Drawing.Point(386, 238);
            this.chkShortPath.Name = "chkShortPath";
            this.chkShortPath.Size = new System.Drawing.Size(94, 23);
            this.chkShortPath.TabIndex = 4;
            this.chkShortPath.Text = "短いパス表示";
            //
            // chkClipboard
            //
            this.chkClipboard.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkClipboard.Location = new System.Drawing.Point(386, 264);
            this.chkClipboard.Name = "chkClipboard";
            this.chkClipboard.Size = new System.Drawing.Size(94, 46);
            this.chkClipboard.TabIndex = 5;
            this.chkClipboard.Text = "クリップボードへ転記";

            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 296);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tvFolders);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkShortPath);
            this.Controls.Add(this.chkClipboard);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDialogFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "フォルダの選択";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private C1.Win.C1Input.C1Label        lblTitle;
        private System.Windows.Forms.TreeView tvFolders;
        private C1.Win.C1Input.C1Button       btnOK;
        private C1.Win.C1Input.C1Button       btnCancel;
        private System.Windows.Forms.CheckBox chkShortPath;
        private System.Windows.Forms.CheckBox chkClipboard;

        #endregion
    }
}