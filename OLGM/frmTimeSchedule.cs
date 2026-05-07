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
    public partial class frmTimeSchedule : Form
    {
        // チャート描画定数
        private const int ChartLeft   = 50;   // ラベル幅
        private const int ChartTop    = 20;   // ヘッダ高
        private const int RowHeight   = 14;
        private static readonly string[] RowLabels = { "SV 1","SV 2","SV 3","SV 4","SV 5","SV 6","SV 7","SV 8","MCA","転送" };

        public frmTimeSchedule()
        {
            InitializeComponent();
        }

        // ── ガントチャート描画 ────────────────────────────────
        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g   = e.Graphics;
            int w        = pnlChart.ClientSize.Width - ChartLeft - 80; // 右余白
            int maxMin   = 60;
            if (int.TryParse(txtMaxTime.Text, out int parsed) && parsed > 0)
                maxMin = parsed;
            int maxSec   = maxMin * 60;

            var labelFont  = new System.Drawing.Font("メイリオ", 8F);
            var headerFont = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Bold);
            var barBrush   = System.Drawing.Brushes.Lime;
            var gridPen    = System.Drawing.Pens.LightGray;
            var axisPen    = System.Drawing.Pens.Black;

            // ヘッダ
            g.DrawString("Valves", headerFont, System.Drawing.Brushes.Black, 2, ChartTop);
            g.DrawString("Time schedule", headerFont, System.Drawing.Brushes.Black, ChartLeft + 4, 4);

            // 行ラベルと横グリッド
            for (int i = 0; i < RowLabels.Length; i++)
            {
                int y = ChartTop + i * RowHeight;
                g.DrawString(RowLabels[i], labelFont, System.Drawing.Brushes.Black, 2, y);
                g.DrawLine(gridPen, ChartLeft, y, ChartLeft + w, y);
            }

            // X軸目盛
            int tickCount = 6;
            for (int t = 0; t <= tickCount; t++)
            {
                int x   = ChartLeft + t * w / tickCount;
                int min = t * maxMin / tickCount;
                string lbl = t == tickCount / 2 ? $"{min}.0 [min]" : (t == 0 ? "0" : $"{min}.0");
                g.DrawLine(axisPen, x, ChartTop, x, ChartTop + RowLabels.Length * RowHeight);
                g.DrawString(lbl, labelFont, System.Drawing.Brushes.Black, x - 8,
                    ChartTop + RowLabels.Length * RowHeight + 2);
            }

            // バルブスケジュールをチャートに描画
            foreach (DataGridViewRow row in dgvValve.Rows)
            {
                if (row.IsNewRow) continue;
                if (!int.TryParse(row.Cells["colSVNo"].Value?.ToString(), out int svNo)) continue;
                if (!int.TryParse(row.Cells["colON"].Value?.ToString(), out int onSec)) continue;
                if (!int.TryParse(row.Cells["colDuration"].Value?.ToString(), out int dur)) continue;

                int rowIdx = svNo - 1;
                if (rowIdx < 0 || rowIdx >= RowLabels.Length) continue;

                int xStart = ChartLeft + (int)((double)onSec / maxSec * w);
                int xEnd   = ChartLeft + (int)((double)(onSec + dur) / maxSec * w);
                int y      = ChartTop + rowIdx * RowHeight + 2;
                g.FillRectangle(barBrush, xStart, y, Math.Max(1, xEnd - xStart), RowHeight - 4);
            }

            labelFont.Dispose();
            headerFont.Dispose();
        }

        // ── イベントハンドラ ──────────────────────────────────
        private void txtMaxTime_TextChanged(object sender, EventArgs e)
        {
            pnlChart.Invalidate();
        }

        private void btnSetRange_Click(object sender, EventArgs e)
        {
            // ON期間と系統によるフィルタリング（実装は呼び出し元データに依存）
            pnlChart.Invalidate();
        }

        private void btnSetFlow_Click(object sender, EventArgs e)
        {
            // 流量指示値転送タイミング設定（実装は呼び出し元データに依存）
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pnlChart.Invalidate();
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
