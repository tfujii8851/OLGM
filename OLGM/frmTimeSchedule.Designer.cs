namespace OLGM
{
    partial class frmTimeSchedule
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
            this.menuStrip1      = new System.Windows.Forms.MenuStrip();
            this.mnuFile         = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView         = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp         = new System.Windows.Forms.ToolStripMenuItem();

            this.pnlChart        = new System.Windows.Forms.Panel();
            this.lblSetMax       = new C1.Win.C1Input.C1Label();
            this.txtMaxTime      = new C1.Win.C1Input.C1TextBox();

            this.lblTitle1       = new C1.Win.C1Input.C1Label();
            this.lblTitle2       = new C1.Win.C1Input.C1Label();

            this.pnlValve        = new C1.Win.C1InputPanel.C1InputPanel();
            this.lblOnPeriod     = new C1.Win.C1Input.C1Label();
            this.numFrom         = new C1.Win.C1Input.C1NumericEdit();
            this.lblTilde        = new C1.Win.C1Input.C1Label();
            this.numTo           = new C1.Win.C1Input.C1NumericEdit();
            this.rbSys1          = new System.Windows.Forms.RadioButton();
            this.rbSys2          = new System.Windows.Forms.RadioButton();
            this.btnSetRange     = new C1.Win.C1Input.C1Button();
            this.dgvValve        = new System.Windows.Forms.DataGridView();
            this.colValveNo      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSVNo         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colON           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOFF          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMask         = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlFlow         = new C1.Win.C1InputPanel.C1InputPanel();
            this.numFlowTiming   = new C1.Win.C1Input.C1NumericEdit();
            this.btnSetFlow      = new C1.Win.C1Input.C1Button();
            this.dgvFlow         = new System.Windows.Forms.DataGridView();
            this.colFlowNo       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiming       = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.lblNote         = new C1.Win.C1Input.C1Label();
            this.btnRefresh      = new C1.Win.C1Input.C1Button();
            this.btnOK           = new C1.Win.C1Input.C1Button();
            this.btnCancel       = new C1.Win.C1Input.C1Button();

            // ── BeginInit ────────────────────────────────────
            this.menuStrip1.SuspendLayout();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblSetMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlValve)).BeginInit();
            this.pnlValve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblOnPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTilde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFlow)).BeginInit();
            this.pnlFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFlowTiming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();

            // ── MenuStrip ────────────────────────────────────
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuFile, this.mnuView, this.mnuHelp });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 25);
            this.menuStrip1.TabIndex = 0;
            //
            // mnuFile
            //
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(80, 21);
            this.mnuFile.Text = "ファイル(&F)";
            //
            // mnuView
            //
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(60, 21);
            this.mnuView.Text = "表示(&V)";
            //
            // mnuHelp
            //
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(65, 21);
            this.mnuHelp.Text = "ヘルプ(&H)";

            // ── pnlChart ─────────────────────────────────────
            //
            // lblSetMax (inside pnlChart)
            //
            this.lblSetMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSetMax.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSetMax.Location = new System.Drawing.Point(590, 165);
            this.lblSetMax.Name = "lblSetMax";
            this.lblSetMax.Size = new System.Drawing.Size(30, 20);
            this.lblSetMax.TabIndex = 0;
            this.lblSetMax.Tag = null;
            this.lblSetMax.Text = "設定";
            //
            // txtMaxTime (inside pnlChart)
            //
            this.txtMaxTime.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMaxTime.Location = new System.Drawing.Point(622, 163);
            this.txtMaxTime.Name = "txtMaxTime";
            this.txtMaxTime.Size = new System.Drawing.Size(50, 24);
            this.txtMaxTime.TabIndex = 1;
            this.txtMaxTime.Tag = null;
            this.txtMaxTime.Text = "60";
            this.txtMaxTime.TextChanged += new System.EventHandler(this.txtMaxTime_TextChanged);
            //
            // pnlChart
            //
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChart.Controls.Add(this.lblSetMax);
            this.pnlChart.Controls.Add(this.txtMaxTime);
            this.pnlChart.Location = new System.Drawing.Point(0, 25);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(680, 190);
            this.pnlChart.TabIndex = 1;
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);

            // ── セクションタイトル ─────────────────────────────
            //
            // lblTitle1
            //
            this.lblTitle1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTitle1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle1.Location = new System.Drawing.Point(8, 218);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(550, 20);
            this.lblTitle1.TabIndex = 2;
            this.lblTitle1.Tag = null;
            this.lblTitle1.Text = "バルブ開時間、MCA作動時間、流量指示値転送時間設定";
            //
            // lblTitle2
            //
            this.lblTitle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTitle2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle2.Location = new System.Drawing.Point(8, 238);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(250, 20);
            this.lblTitle2.TabIndex = 3;
            this.lblTitle2.Tag = null;
            this.lblTitle2.Text = "バルブ開、MCA作動設定";

            // ── pnlValve ─────────────────────────────────────
            //
            // lblOnPeriod
            //
            this.lblOnPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblOnPeriod.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOnPeriod.Location = new System.Drawing.Point(5, 16);
            this.lblOnPeriod.Name = "lblOnPeriod";
            this.lblOnPeriod.Size = new System.Drawing.Size(62, 20);
            this.lblOnPeriod.TabIndex = 0;
            this.lblOnPeriod.Tag = null;
            this.lblOnPeriod.Text = "ON期間:";
            //
            // numFrom
            //
            this.numFrom.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numFrom.Location = new System.Drawing.Point(70, 14);
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(50, 22);
            this.numFrom.TabIndex = 1;
            this.numFrom.Tag = null;
            this.numFrom.Value = 0M;
            //
            // lblTilde
            //
            this.lblTilde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTilde.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTilde.Location = new System.Drawing.Point(123, 16);
            this.lblTilde.Name = "lblTilde";
            this.lblTilde.Size = new System.Drawing.Size(16, 20);
            this.lblTilde.TabIndex = 2;
            this.lblTilde.Tag = null;
            this.lblTilde.Text = "〜";
            //
            // numTo
            //
            this.numTo.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numTo.Location = new System.Drawing.Point(141, 14);
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(50, 22);
            this.numTo.TabIndex = 3;
            this.numTo.Tag = null;
            this.numTo.Value = 0M;
            //
            // rbSys1
            //
            this.rbSys1.AutoSize = true;
            this.rbSys1.Checked = true;
            this.rbSys1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbSys1.Location = new System.Drawing.Point(197, 15);
            this.rbSys1.Name = "rbSys1";
            this.rbSys1.Size = new System.Drawing.Size(55, 23);
            this.rbSys1.TabIndex = 4;
            this.rbSys1.TabStop = true;
            this.rbSys1.Text = "系統1";
            //
            // rbSys2
            //
            this.rbSys2.AutoSize = true;
            this.rbSys2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbSys2.Location = new System.Drawing.Point(258, 15);
            this.rbSys2.Name = "rbSys2";
            this.rbSys2.Size = new System.Drawing.Size(55, 23);
            this.rbSys2.TabIndex = 5;
            this.rbSys2.Text = "系統2";
            //
            // btnSetRange
            //
            this.btnSetRange.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSetRange.Location = new System.Drawing.Point(318, 13);
            this.btnSetRange.Name = "btnSetRange";
            this.btnSetRange.Size = new System.Drawing.Size(50, 23);
            this.btnSetRange.TabIndex = 6;
            this.btnSetRange.Tag = null;
            this.btnSetRange.Text = "設定";
            this.btnSetRange.Click += new System.EventHandler(this.btnSetRange_Click);
            //
            // colValveNo
            //
            this.colValveNo.HeaderText = "#";
            this.colValveNo.Name = "colValveNo";
            this.colValveNo.Width = 30;
            //
            // colSVNo
            //
            this.colSVNo.HeaderText = "SV#";
            this.colSVNo.Name = "colSVNo";
            this.colSVNo.Width = 40;
            //
            // colON
            //
            this.colON.HeaderText = "ON(sec)";
            this.colON.Name = "colON";
            this.colON.Width = 62;
            //
            // colOFF
            //
            this.colOFF.HeaderText = "OFF(sec)";
            this.colOFF.Name = "colOFF";
            this.colOFF.Width = 65;
            //
            // colDuration
            //
            this.colDuration.HeaderText = "Duration";
            this.colDuration.Name = "colDuration";
            this.colDuration.Width = 65;
            //
            // colMask
            //
            this.colMask.HeaderText = "Mask";
            this.colMask.Name = "colMask";
            this.colMask.Width = 45;
            //
            // dgvValve
            //
            this.dgvValve.AllowUserToAddRows = false;
            this.dgvValve.AllowUserToDeleteRows = false;
            this.dgvValve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colValveNo, this.colSVNo, this.colON, this.colOFF, this.colDuration, this.colMask });
            this.dgvValve.Font = new System.Drawing.Font("メイリオ", 9F);
            this.dgvValve.Location = new System.Drawing.Point(5, 40);
            this.dgvValve.Name = "dgvValve";
            this.dgvValve.ReadOnly = true;
            this.dgvValve.RowTemplate.Height = 21;
            this.dgvValve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValve.Size = new System.Drawing.Size(368, 175);
            this.dgvValve.TabIndex = 7;
            //
            // pnlValve
            //
            this.pnlValve.BorderThickness = 1;
            this.pnlValve.Controls.Add(this.lblOnPeriod);
            this.pnlValve.Controls.Add(this.numFrom);
            this.pnlValve.Controls.Add(this.lblTilde);
            this.pnlValve.Controls.Add(this.numTo);
            this.pnlValve.Controls.Add(this.rbSys1);
            this.pnlValve.Controls.Add(this.rbSys2);
            this.pnlValve.Controls.Add(this.btnSetRange);
            this.pnlValve.Controls.Add(this.dgvValve);
            this.pnlValve.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlValve.Location = new System.Drawing.Point(8, 256);
            this.pnlValve.Name = "pnlValve";
            this.pnlValve.Size = new System.Drawing.Size(380, 222);
            this.pnlValve.TabIndex = 4;
            this.pnlValve.Text = "";

            // ── pnlFlow ───────────────────────────────────────
            //
            // numFlowTiming
            //
            this.numFlowTiming.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numFlowTiming.Location = new System.Drawing.Point(5, 14);
            this.numFlowTiming.Name = "numFlowTiming";
            this.numFlowTiming.Size = new System.Drawing.Size(80, 22);
            this.numFlowTiming.TabIndex = 0;
            this.numFlowTiming.Tag = null;
            this.numFlowTiming.Value = 0M;
            //
            // btnSetFlow
            //
            this.btnSetFlow.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSetFlow.Location = new System.Drawing.Point(90, 13);
            this.btnSetFlow.Name = "btnSetFlow";
            this.btnSetFlow.Size = new System.Drawing.Size(50, 23);
            this.btnSetFlow.TabIndex = 1;
            this.btnSetFlow.Tag = null;
            this.btnSetFlow.Text = "設定";
            this.btnSetFlow.Click += new System.EventHandler(this.btnSetFlow_Click);
            //
            // colFlowNo
            //
            this.colFlowNo.HeaderText = "#";
            this.colFlowNo.Name = "colFlowNo";
            this.colFlowNo.Width = 40;
            //
            // colTiming
            //
            this.colTiming.HeaderText = "Timing";
            this.colTiming.Name = "colTiming";
            this.colTiming.Width = 80;
            //
            // dgvFlow
            //
            this.dgvFlow.AllowUserToAddRows = false;
            this.dgvFlow.AllowUserToDeleteRows = false;
            this.dgvFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colFlowNo, this.colTiming });
            this.dgvFlow.Font = new System.Drawing.Font("メイリオ", 9F);
            this.dgvFlow.Location = new System.Drawing.Point(5, 40);
            this.dgvFlow.Name = "dgvFlow";
            this.dgvFlow.ReadOnly = true;
            this.dgvFlow.RowTemplate.Height = 21;
            this.dgvFlow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlow.Size = new System.Drawing.Size(148, 175);
            this.dgvFlow.TabIndex = 2;
            //
            // pnlFlow
            //
            this.pnlFlow.BorderThickness = 1;
            this.pnlFlow.Controls.Add(this.numFlowTiming);
            this.pnlFlow.Controls.Add(this.btnSetFlow);
            this.pnlFlow.Controls.Add(this.dgvFlow);
            this.pnlFlow.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlFlow.Location = new System.Drawing.Point(396, 256);
            this.pnlFlow.Name = "pnlFlow";
            this.pnlFlow.Size = new System.Drawing.Size(160, 222);
            this.pnlFlow.TabIndex = 5;
            this.pnlFlow.Text = "流量指示値転送時間設定";

            // ── 注記・ボタン ──────────────────────────────────
            //
            // lblNote
            //
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNote.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNote.Location = new System.Drawing.Point(562, 256);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(112, 52);
            this.lblNote.TabIndex = 6;
            this.lblNote.Tag = null;
            this.lblNote.Text = "注)この枠内の設定単位は秒です";
            //
            // btnRefresh
            //
            this.btnRefresh.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRefresh.Location = new System.Drawing.Point(562, 318);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Tag = null;
            this.btnRefresh.Text = "表示更新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // btnOK
            //
            this.btnOK.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOK.Location = new System.Drawing.Point(562, 364);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 8;
            this.btnOK.Tag = null;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            // btnCancel
            //
            this.btnCancel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(562, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Tag = null;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ── EndInit ───────────────────────────────────────
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblSetMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOnPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTilde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValve)).EndInit();
            this.pnlValve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlValve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFlowTiming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlow)).EndInit();
            this.pnlFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();

            // ── フォーム設定 ───────────────────────────────────
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 490);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.pnlValve);
            this.Controls.Add(this.pnlFlow);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTimeSchedule";
            this.Text = "スケジュール設定";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── フィールド宣言 ────────────────────────────────────
        private System.Windows.Forms.MenuStrip                     menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem             mnuFile;
        private System.Windows.Forms.ToolStripMenuItem             mnuView;
        private System.Windows.Forms.ToolStripMenuItem             mnuHelp;
        private System.Windows.Forms.Panel                         pnlChart;
        private C1.Win.C1Input.C1Label                             lblSetMax;
        private C1.Win.C1Input.C1TextBox                           txtMaxTime;
        private C1.Win.C1Input.C1Label                             lblTitle1;
        private C1.Win.C1Input.C1Label                             lblTitle2;
        private C1.Win.C1InputPanel.C1InputPanel                   pnlValve;
        private C1.Win.C1Input.C1Label                             lblOnPeriod;
        private C1.Win.C1Input.C1NumericEdit                       numFrom;
        private C1.Win.C1Input.C1Label                             lblTilde;
        private C1.Win.C1Input.C1NumericEdit                       numTo;
        private System.Windows.Forms.RadioButton                   rbSys1;
        private System.Windows.Forms.RadioButton                   rbSys2;
        private C1.Win.C1Input.C1Button                            btnSetRange;
        private System.Windows.Forms.DataGridView                  dgvValve;
        private System.Windows.Forms.DataGridViewTextBoxColumn     colValveNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn     colSVNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn     colON;
        private System.Windows.Forms.DataGridViewTextBoxColumn     colOFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn     colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn     colMask;
        private C1.Win.C1InputPanel.C1InputPanel                   pnlFlow;
        private C1.Win.C1Input.C1NumericEdit                       numFlowTiming;
        private C1.Win.C1Input.C1Button                            btnSetFlow;
        private System.Windows.Forms.DataGridView                  dgvFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn     colFlowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn     colTiming;
        private C1.Win.C1Input.C1Label                             lblNote;
        private C1.Win.C1Input.C1Button                            btnRefresh;
        private C1.Win.C1Input.C1Button                            btnOK;
        private C1.Win.C1Input.C1Button                            btnCancel;

        #endregion
    }
}