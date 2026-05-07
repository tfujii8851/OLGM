namespace OLGM
{
    partial class frmMeasCarryOut
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
            this.lblInstruction1       = new C1.Win.C1Input.C1Label();
            this.lblInstruction2       = new C1.Win.C1Input.C1Label();
            this.lblWarning            = new C1.Win.C1Input.C1Label();
            this.lblDateTime           = new C1.Win.C1Input.C1Label();
            this.lblSaveConfirm        = new C1.Win.C1Input.C1Label();
            this.lblSpectrumFolderTitle = new C1.Win.C1Input.C1Label();

            this.pnlAnalysis           = new C1.Win.C1InputPanel.C1InputPanel();
            this.lblAnalysisPath       = new C1.Win.C1Input.C1Label();

            this.pnlLAN                = new C1.Win.C1InputPanel.C1InputPanel();
            this.lblLANPath            = new C1.Win.C1Input.C1Label();

            this.pnlInternal           = new C1.Win.C1InputPanel.C1InputPanel();
            this.lblInternalPath       = new C1.Win.C1Input.C1Label();

            this.lblFlowRateTitle      = new C1.Win.C1Input.C1Label();

            this.pnlFlowLAN            = new C1.Win.C1InputPanel.C1InputPanel();
            this.lblFlowLANPath        = new C1.Win.C1Input.C1Label();

            this.pnlFlowInternal       = new C1.Win.C1InputPanel.C1InputPanel();
            this.lblFlowInternalPath   = new C1.Win.C1Input.C1Label();

            this.btnOK                 = new C1.Win.C1Input.C1Button();
            this.btnCancel             = new C1.Win.C1Input.C1Button();

            // ── BeginInit ────────────────────────────────────
            ((System.ComponentModel.ISupportInitialize)(this.lblInstruction1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInstruction2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSaveConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpectrumFolderTitle)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.pnlAnalysis)).BeginInit();
            this.pnlAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblAnalysisPath)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.pnlLAN)).BeginInit();
            this.pnlLAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLANPath)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.pnlInternal)).BeginInit();
            this.pnlInternal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblInternalPath)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.lblFlowRateTitle)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.pnlFlowLAN)).BeginInit();
            this.pnlFlowLAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFlowLANPath)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.pnlFlowInternal)).BeginInit();
            this.pnlFlowInternal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFlowInternalPath)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();

            // ── 上部テキスト ──────────────────────────────────
            //
            // lblInstruction1
            //
            this.lblInstruction1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInstruction1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInstruction1.Location = new System.Drawing.Point(8, 8);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(622, 20);
            this.lblInstruction1.TabIndex = 0;
            this.lblInstruction1.Tag = null;
            this.lblInstruction1.Text = "各保存先を確認してOKボタンを選択して下さい。";
            //
            // lblInstruction2
            //
            this.lblInstruction2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInstruction2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInstruction2.Location = new System.Drawing.Point(8, 28);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(622, 20);
            this.lblInstruction2.TabIndex = 1;
            this.lblInstruction2.Tag = null;
            this.lblInstruction2.Text = "設定をやり直す場合は、条件設定に戻って行って下さい。";
            //
            // lblWarning
            //
            this.lblWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblWarning.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWarning.Location = new System.Drawing.Point(8, 48);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(622, 20);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Tag = null;
            this.lblWarning.Text = "橙色で示す設定フォルダにアクセスできません。設定し直して下さい。";
            this.lblWarning.Visible = false;
            //
            // lblDateTime
            //
            this.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDateTime.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDateTime.Location = new System.Drawing.Point(390, 68);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(240, 20);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Tag = null;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── 保存先確認セクション ────────────────────────────
            //
            // lblSaveConfirm
            //
            this.lblSaveConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSaveConfirm.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSaveConfirm.Location = new System.Drawing.Point(8, 92);
            this.lblSaveConfirm.Name = "lblSaveConfirm";
            this.lblSaveConfirm.Size = new System.Drawing.Size(200, 20);
            this.lblSaveConfirm.TabIndex = 4;
            this.lblSaveConfirm.Tag = null;
            this.lblSaveConfirm.Text = "保存先確認";
            //
            // lblSpectrumFolderTitle
            //
            this.lblSpectrumFolderTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSpectrumFolderTitle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSpectrumFolderTitle.Location = new System.Drawing.Point(8, 112);
            this.lblSpectrumFolderTitle.Name = "lblSpectrumFolderTitle";
            this.lblSpectrumFolderTitle.Size = new System.Drawing.Size(300, 20);
            this.lblSpectrumFolderTitle.TabIndex = 5;
            this.lblSpectrumFolderTitle.Tag = null;
            this.lblSpectrumFolderTitle.Text = "スペクトルファイル保存先フォルダ:";

            // ── pnlAnalysis ───────────────────────────────────
            //
            // lblAnalysisPath
            //
            this.lblAnalysisPath.BackColor = System.Drawing.Color.Orange;
            this.lblAnalysisPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAnalysisPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAnalysisPath.Location = new System.Drawing.Point(5, 14);
            this.lblAnalysisPath.Name = "lblAnalysisPath";
            this.lblAnalysisPath.Size = new System.Drawing.Size(596, 22);
            this.lblAnalysisPath.TabIndex = 0;
            this.lblAnalysisPath.Tag = null;
            this.lblAnalysisPath.Text = @"C:\OKENTEST\Analysis";
            //
            // pnlAnalysis
            //
            this.pnlAnalysis.BorderThickness = 1;
            this.pnlAnalysis.Controls.Add(this.lblAnalysisPath);
            this.pnlAnalysis.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlAnalysis.Location = new System.Drawing.Point(16, 130);
            this.pnlAnalysis.Name = "pnlAnalysis";
            this.pnlAnalysis.Size = new System.Drawing.Size(608, 42);
            this.pnlAnalysis.TabIndex = 6;
            this.pnlAnalysis.Text = "測定結果の保存先フォルダ(解析用)(解析後削除されます)";

            // ── pnlLAN ────────────────────────────────────────
            //
            // lblLANPath
            //
            this.lblLANPath.BackColor = System.Drawing.Color.Orange;
            this.lblLANPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLANPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLANPath.Location = new System.Drawing.Point(5, 14);
            this.lblLANPath.Name = "lblLANPath";
            this.lblLANPath.Size = new System.Drawing.Size(596, 22);
            this.lblLANPath.TabIndex = 0;
            this.lblLANPath.Tag = null;
            this.lblLANPath.Text = @"H:\OKEN\Spectrum";
            //
            // pnlLAN
            //
            this.pnlLAN.BorderThickness = 1;
            this.pnlLAN.Controls.Add(this.lblLANPath);
            this.pnlLAN.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlLAN.Location = new System.Drawing.Point(16, 176);
            this.pnlLAN.Name = "pnlLAN";
            this.pnlLAN.Size = new System.Drawing.Size(608, 42);
            this.pnlLAN.TabIndex = 7;
            this.pnlLAN.Text = "測定結果の保存先フォルダ(LAN接続サーバ用)";

            // ── pnlInternal ───────────────────────────────────
            //
            // lblInternalPath
            //
            this.lblInternalPath.BackColor = System.Drawing.Color.Orange;
            this.lblInternalPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInternalPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInternalPath.Location = new System.Drawing.Point(5, 14);
            this.lblInternalPath.Name = "lblInternalPath";
            this.lblInternalPath.Size = new System.Drawing.Size(596, 22);
            this.lblInternalPath.TabIndex = 0;
            this.lblInternalPath.Tag = null;
            this.lblInternalPath.Text = @"C:\OKENTEST\His";
            //
            // pnlInternal
            //
            this.pnlInternal.BorderThickness = 1;
            this.pnlInternal.Controls.Add(this.lblInternalPath);
            this.pnlInternal.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlInternal.Location = new System.Drawing.Point(16, 222);
            this.pnlInternal.Name = "pnlInternal";
            this.pnlInternal.Size = new System.Drawing.Size(608, 42);
            this.pnlInternal.TabIndex = 8;
            this.pnlInternal.Text = "測定結果の保存先フォルダ(内部保管用等)";

            // ── 流量指示値セクション ────────────────────────────
            //
            // lblFlowRateTitle
            //
            this.lblFlowRateTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblFlowRateTitle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFlowRateTitle.Location = new System.Drawing.Point(8, 274);
            this.lblFlowRateTitle.Name = "lblFlowRateTitle";
            this.lblFlowRateTitle.Size = new System.Drawing.Size(300, 20);
            this.lblFlowRateTitle.TabIndex = 9;
            this.lblFlowRateTitle.Tag = null;
            this.lblFlowRateTitle.Text = "流量指示値時系列ファイル:";

            // ── pnlFlowLAN ────────────────────────────────────
            //
            // lblFlowLANPath
            //
            this.lblFlowLANPath.BackColor = System.Drawing.Color.Orange;
            this.lblFlowLANPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblFlowLANPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFlowLANPath.Location = new System.Drawing.Point(5, 14);
            this.lblFlowLANPath.Name = "lblFlowLANPath";
            this.lblFlowLANPath.Size = new System.Drawing.Size(596, 22);
            this.lblFlowLANPath.TabIndex = 0;
            this.lblFlowLANPath.Tag = null;
            this.lblFlowLANPath.Text = @"H:\OKEN\Flowrate\OLGMM 1.00 R7.LST";
            //
            // pnlFlowLAN
            //
            this.pnlFlowLAN.BorderThickness = 1;
            this.pnlFlowLAN.Controls.Add(this.lblFlowLANPath);
            this.pnlFlowLAN.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlFlowLAN.Location = new System.Drawing.Point(16, 292);
            this.pnlFlowLAN.Name = "pnlFlowLAN";
            this.pnlFlowLAN.Size = new System.Drawing.Size(608, 42);
            this.pnlFlowLAN.TabIndex = 10;
            this.pnlFlowLAN.Text = "流量指示値時系列記録ファイル(LAN接続サーバ用)";

            // ── pnlFlowInternal ───────────────────────────────
            //
            // lblFlowInternalPath
            //
            this.lblFlowInternalPath.BackColor = System.Drawing.Color.Orange;
            this.lblFlowInternalPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblFlowInternalPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFlowInternalPath.Location = new System.Drawing.Point(5, 14);
            this.lblFlowInternalPath.Name = "lblFlowInternalPath";
            this.lblFlowInternalPath.Size = new System.Drawing.Size(596, 22);
            this.lblFlowInternalPath.TabIndex = 0;
            this.lblFlowInternalPath.Tag = null;
            this.lblFlowInternalPath.Text = @"C:\OKENTEST\Lis\OLGMM 1.00 R7.LST";
            //
            // pnlFlowInternal
            //
            this.pnlFlowInternal.BorderThickness = 1;
            this.pnlFlowInternal.Controls.Add(this.lblFlowInternalPath);
            this.pnlFlowInternal.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlFlowInternal.Location = new System.Drawing.Point(16, 338);
            this.pnlFlowInternal.Name = "pnlFlowInternal";
            this.pnlFlowInternal.Size = new System.Drawing.Size(608, 42);
            this.pnlFlowInternal.TabIndex = 11;
            this.pnlFlowInternal.Text = "流量指示値時系列記録ファイル(内部保管用等)";

            // ── ボタン ────────────────────────────────────────
            //
            // btnOK
            //
            this.btnOK.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOK.Location = new System.Drawing.Point(476, 400);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 28);
            this.btnOK.TabIndex = 12;
            this.btnOK.Tag = null;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            // btnCancel
            //
            this.btnCancel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(556, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 28);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Tag = null;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ── EndInit ───────────────────────────────────────
            ((System.ComponentModel.ISupportInitialize)(this.lblInstruction1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInstruction2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSaveConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSpectrumFolderTitle)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.lblAnalysisPath)).EndInit();
            this.pnlAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAnalysis)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.lblLANPath)).EndInit();
            this.pnlLAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLAN)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.lblInternalPath)).EndInit();
            this.pnlInternal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInternal)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.lblFlowRateTitle)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.lblFlowLANPath)).EndInit();
            this.pnlFlowLAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFlowLAN)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.lblFlowInternalPath)).EndInit();
            this.pnlFlowInternal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFlowInternal)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();

            // ── フォーム設定 ───────────────────────────────────
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 440);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblSaveConfirm);
            this.Controls.Add(this.lblSpectrumFolderTitle);
            this.Controls.Add(this.pnlAnalysis);
            this.Controls.Add(this.pnlLAN);
            this.Controls.Add(this.pnlInternal);
            this.Controls.Add(this.lblFlowRateTitle);
            this.Controls.Add(this.pnlFlowLAN);
            this.Controls.Add(this.pnlFlowInternal);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMeasCarryOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "自動測定";
            this.ResumeLayout(false);
        }

        // ── フィールド宣言 ────────────────────────────────────
        private C1.Win.C1Input.C1Label       lblInstruction1;
        private C1.Win.C1Input.C1Label       lblInstruction2;
        private C1.Win.C1Input.C1Label       lblWarning;
        private C1.Win.C1Input.C1Label       lblDateTime;
        private C1.Win.C1Input.C1Label       lblSaveConfirm;
        private C1.Win.C1Input.C1Label       lblSpectrumFolderTitle;
        private C1.Win.C1InputPanel.C1InputPanel pnlAnalysis;
        private C1.Win.C1Input.C1Label       lblAnalysisPath;
        private C1.Win.C1InputPanel.C1InputPanel pnlLAN;
        private C1.Win.C1Input.C1Label       lblLANPath;
        private C1.Win.C1InputPanel.C1InputPanel pnlInternal;
        private C1.Win.C1Input.C1Label       lblInternalPath;
        private C1.Win.C1Input.C1Label       lblFlowRateTitle;
        private C1.Win.C1InputPanel.C1InputPanel pnlFlowLAN;
        private C1.Win.C1Input.C1Label       lblFlowLANPath;
        private C1.Win.C1InputPanel.C1InputPanel pnlFlowInternal;
        private C1.Win.C1Input.C1Label       lblFlowInternalPath;
        private C1.Win.C1Input.C1Button      btnOK;
        private C1.Win.C1Input.C1Button      btnCancel;

        #endregion
    }
}