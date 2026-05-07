namespace OLGM
{
    partial class frmFileList
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
            // ── 宣言 ──────────────────────────────────────────
            this.lblLeftTitle   = new C1.Win.C1Input.C1Label();
            this.lblRightTitle  = new C1.Win.C1Input.C1Label();
            this.lvLeft         = new System.Windows.Forms.ListView();
            this.colLNo         = new System.Windows.Forms.ColumnHeader();
            this.colLFilename   = new System.Windows.Forms.ColumnHeader();
            this.colLStep       = new System.Windows.Forms.ColumnHeader();
            this.colLDate       = new System.Windows.Forms.ColumnHeader();
            this.colLFullPath   = new System.Windows.Forms.ColumnHeader();
            this.lvRight        = new System.Windows.Forms.ListView();
            this.colRNo         = new System.Windows.Forms.ColumnHeader();
            this.colRFilename   = new System.Windows.Forms.ColumnHeader();
            this.colRStep       = new System.Windows.Forms.ColumnHeader();
            this.colRDate       = new System.Windows.Forms.ColumnHeader();
            this.colRFullPath   = new System.Windows.Forms.ColumnHeader();
            this.lblStatus1     = new C1.Win.C1Input.C1Label();
            this.lblStatus2     = new C1.Win.C1Input.C1Label();
            this.lblStatus3     = new C1.Win.C1Input.C1Label();

            ((System.ComponentModel.ISupportInitialize)(this.lblLeftTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRightTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus3)).BeginInit();
            this.SuspendLayout();

            // ── lblLeftTitle ──────────────────────────────────
            this.lblLeftTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLeftTitle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLeftTitle.Location = new System.Drawing.Point(8, 6);
            this.lblLeftTitle.Name = "lblLeftTitle";
            this.lblLeftTitle.Size = new System.Drawing.Size(310, 20);
            this.lblLeftTitle.TabIndex = 0;
            this.lblLeftTitle.Tag = null;
            this.lblLeftTitle.Text = "対象取得スペクトルファイル一覧";

            // ── lblRightTitle ─────────────────────────────────
            this.lblRightTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRightTitle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRightTitle.Location = new System.Drawing.Point(326, 6);
            this.lblRightTitle.Name = "lblRightTitle";
            this.lblRightTitle.Size = new System.Drawing.Size(310, 20);
            this.lblRightTitle.TabIndex = 1;
            this.lblRightTitle.Tag = null;
            this.lblRightTitle.Text = "対象解析スペクトルファイル一覧  0/ 0";

            // ── 左 ListView 列定義 ────────────────────────────
            this.colLNo.Text  = "No.";        this.colLNo.Width  = 36;
            this.colLFilename.Text = "Filename";   this.colLFilename.Width = 120;
            this.colLStep.Text = "Step";      this.colLStep.Width = 40;
            this.colLDate.Text = "Date last modified"; this.colLDate.Width = 120;
            this.colLFullPath.Text = "Filename by fu"; this.colLFullPath.Width = 200;
            //
            // lvLeft
            //
            this.lvLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colLNo, this.colLFilename, this.colLStep, this.colLDate, this.colLFullPath });
            this.lvLeft.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lvLeft.FullRowSelect = true;
            this.lvLeft.GridLines = true;
            this.lvLeft.Location = new System.Drawing.Point(8, 28);
            this.lvLeft.Name = "lvLeft";
            this.lvLeft.Size = new System.Drawing.Size(310, 208);
            this.lvLeft.TabIndex = 2;
            this.lvLeft.UseCompatibleStateImageBehavior = false;
            this.lvLeft.View = System.Windows.Forms.View.Details;

            // ── 右 ListView 列定義 ────────────────────────────
            this.colRNo.Text  = "No.";        this.colRNo.Width  = 36;
            this.colRFilename.Text = "Filename";   this.colRFilename.Width = 120;
            this.colRStep.Text = "Step";      this.colRStep.Width = 40;
            this.colRDate.Text = "Date last modified"; this.colRDate.Width = 120;
            this.colRFullPath.Text = "Filename by fu"; this.colRFullPath.Width = 200;
            //
            // lvRight
            //
            this.lvRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colRNo, this.colRFilename, this.colRStep, this.colRDate, this.colRFullPath });
            this.lvRight.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lvRight.FullRowSelect = true;
            this.lvRight.GridLines = true;
            this.lvRight.Location = new System.Drawing.Point(326, 28);
            this.lvRight.Name = "lvRight";
            this.lvRight.Size = new System.Drawing.Size(310, 208);
            this.lvRight.TabIndex = 3;
            this.lvRight.UseCompatibleStateImageBehavior = false;
            this.lvRight.View = System.Windows.Forms.View.Details;

            // ── ステータスラベル ───────────────────────────────
            this.lblStatus1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStatus1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus1.Location = new System.Drawing.Point(8, 242);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(628, 20);
            this.lblStatus1.TabIndex = 4;
            this.lblStatus1.Tag = null;
            this.lblStatus1.Text = "Step欄が、0のスペクトルファイルが各々の選別後当該ファイル";

            this.lblStatus2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStatus2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus2.Location = new System.Drawing.Point(8, 262);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(628, 20);
            this.lblStatus2.TabIndex = 5;
            this.lblStatus2.Tag = null;
            this.lblStatus2.Text = "開始ファイル: ";

            this.lblStatus3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStatus3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus3.Location = new System.Drawing.Point(8, 282);
            this.lblStatus3.Name = "lblStatus3";
            this.lblStatus3.Size = new System.Drawing.Size(628, 20);
            this.lblStatus3.TabIndex = 6;
            this.lblStatus3.Tag = null;
            this.lblStatus3.Text = "終了ファイル: ";

            // ── EndInit ───────────────────────────────────────
            ((System.ComponentModel.ISupportInitialize)(this.lblLeftTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRightTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus3)).EndInit();

            // ── フォーム設定 ───────────────────────────────────
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 308);
            this.Controls.Add(this.lblLeftTitle);
            this.Controls.Add(this.lblRightTitle);
            this.Controls.Add(this.lvLeft);
            this.Controls.Add(this.lvRight);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblStatus3);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmFileList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "解析対象スペクトルファイル一覧";
            this.ResumeLayout(false);
        }

        // ── フィールド宣言 ────────────────────────────────────
        private C1.Win.C1Input.C1Label              lblLeftTitle;
        private C1.Win.C1Input.C1Label              lblRightTitle;
        private System.Windows.Forms.ListView       lvLeft;
        private System.Windows.Forms.ColumnHeader   colLNo;
        private System.Windows.Forms.ColumnHeader   colLFilename;
        private System.Windows.Forms.ColumnHeader   colLStep;
        private System.Windows.Forms.ColumnHeader   colLDate;
        private System.Windows.Forms.ColumnHeader   colLFullPath;
        private System.Windows.Forms.ListView       lvRight;
        private System.Windows.Forms.ColumnHeader   colRNo;
        private System.Windows.Forms.ColumnHeader   colRFilename;
        private System.Windows.Forms.ColumnHeader   colRStep;
        private System.Windows.Forms.ColumnHeader   colRDate;
        private System.Windows.Forms.ColumnHeader   colRFullPath;
        private C1.Win.C1Input.C1Label              lblStatus1;
        private C1.Win.C1Input.C1Label              lblStatus2;
        private C1.Win.C1Input.C1Label              lblStatus3;

        #endregion
    }
}