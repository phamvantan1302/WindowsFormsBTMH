using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsBTMH.models.APIModels;
using WindowsFormsBTMH.models.dashboard;
using WindowsFormsBTMH.services.frmDashboardMain;

namespace WindowsFormsBTMH.form
{
    public partial class DashboardMain : Form
    {
        private Timer clockTimer;
        private string strpo = "";
        List<DMOrder> ListDataOrderByNumberPO = new List<DMOrder>();

        public DashboardMain()
        {
            InitializeComponent();
            flpAlerts.Resize += FlpAlerts_Resize;
            DateTime date = DateTime.Parse("2026-10-29 00:00:00"); //DateTime.Now;
            getData(date);
            LoadDummyData();
            FormatCharts();

            clockTimer = new Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
            UpdateClock();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            lblTime.Text = $"CA LÀM VIỆC \nCa ngày - 08:00-17:15 \n{DateTime.Now:HH:mm:ss}";
        }

        private void getData(DateTime date)
        {

            ListDataOrderByNumberPO = frmDashboardMainServices.CallApiTest(date.ToString("yyyy-MM-dd"));

        }

        private void LoadDummyData()
        {
            Color colorGreen = ColorTranslator.FromHtml("#53C38C");
            Color colorOrange = ColorTranslator.FromHtml("#DE9F4D");
            Color colorBlue = ColorTranslator.FromHtml("#599AEE");
            Color colorRed = ColorTranslator.FromHtml("#E55F60");

            // 1. Chart TIẾN ĐỘ THEO CÔNG ĐOẠN
            var listCongDoan = ListDataOrderByNumberPO.GroupBy(x => x.namecdoan)
                .Select(g => new { namecdoan = g.Key, slht_cdoan = g.Sum(x => x.slht_cdoan) })
                .OrderByDescending(x => x.slht_cdoan)
                .ToList();
            chartTienDo.Series[0].Points.Clear();
            foreach (var item in listCongDoan)
            {
                AddBarPoint(chartTienDo, item.namecdoan, item.slht_cdoan);
            }

            // 2. Chart NHỊP SẢN XUẤT THEO GIỜ
            chartNhipSanXuat.Series[0].Points.Clear();
            AddColumnPoint(chartNhipSanXuat, "07", 86);
            AddColumnPoint(chartNhipSanXuat, "08", 112);
            AddColumnPoint(chartNhipSanXuat, "09", 128);
            AddColumnPoint(chartNhipSanXuat, "10", 121);
            AddColumnPoint(chartNhipSanXuat, "11", 74);
            AddColumnPoint(chartNhipSanXuat, "12", 38);
            AddColumnPoint(chartNhipSanXuat, "13", 96);
            AddColumnPoint(chartNhipSanXuat, "14", 119);

            // 3. Chart PHÂN LOẠI LỖI HÔM NAY
            chartPhanLoaiLoi.Series[0].Points.Clear();
            AddBarPoint(chartPhanLoaiLoi, "Sai trọng lượng", 2);
            AddBarPoint(chartPhanLoaiLoi, "Cong, méo", 2);
            AddBarPoint(chartPhanLoaiLoi, "Xước / đánh bóng", 4);
            AddBarPoint(chartPhanLoaiLoi, "Lỗi hàn", 6);
            AddBarPoint(chartPhanLoaiLoi, "Lỗi gắn đá", 9);

            // 4. Chart TỈ LỆ HOÀN THÀNH
            chartTiLeHoanThanh.Series[0].Points.Clear();
            DataPoint ptCompleted = new DataPoint(0, 842);
            ptCompleted.Color = colorGreen;
            chartTiLeHoanThanh.Series[0].Points.Add(ptCompleted);
            
            DataPoint ptRemaining = new DataPoint(0, 1250 - 842);
            ptRemaining.Color = Color.FromArgb(50, 50, 50); // Dark gray
            chartTiLeHoanThanh.Series[0].Points.Add(ptRemaining);

            // Populate Alerts
            flpAlerts.Controls.Clear();
            flpAlerts.Controls.Add(CreateAlertPanel("Lệch chuẩn hao hụt vàng", "Tổ Đánh bóng - LSX-2026-0512 -\nvượt ngưỡng cho phép", "0,68%", colorRed, "\u223F", "ngưỡng \u2264 0,35%", "15:38"));
            flpAlerts.Controls.Add(CreateAlertPanel("Tỉ lệ NG cao", "Tổ Gắn đá - 14 NG / 226 sp trong ca", "6,2%", colorRed, "!", "ngưỡng \u2264 4,0%", "15:21"));
            flpAlerts.Controls.Add(CreateAlertPanel("Chậm nhịp kế hoạch", "Tổ Gắn đá - tồn 136 sp chờ\nchuyển công đoạn", "-18%", colorOrange, "\u23F2", "so với nhịp chuẩn", "15:05"));
            flpAlerts.Controls.Add(CreateAlertPanel("Lệch chuẩn hao hụt vàng", "Tổ Hàn - LSX-2026-0498 - tiệm cận\nngưỡng", "0,33%", colorOrange, "\u2668", "ngưỡng \u2264 0,35%", "14:47"));
        }

        private void AddBarPoint(Chart chart, string label, double value) //, Color color
        {
            DataPoint pt = new DataPoint();
            pt.SetValueXY(label, value);
            //pt.Color = color;
            pt.LabelForeColor = Color.White;
            pt.IsValueShownAsLabel = true;
            pt.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            chart.Series[0].Points.Add(pt);
        }

        private void AddColumnPoint(Chart chart, string label, double value) //, Color color
        {
            DataPoint pt = new DataPoint();
            pt.SetValueXY(label, value);
            //pt.Color = color;
            pt.LabelForeColor = Color.White;
            pt.IsValueShownAsLabel = true;
            pt.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            chart.Series[0].Points.Add(pt);
        } 

        private void FormatCharts()
        {
            Color bgColor = ColorTranslator.FromHtml("#211C19");
            Color gridColor = Color.FromArgb(50, 50, 50);

            foreach (var chart in new[] { chartTienDo, chartNhipSanXuat, chartPhanLoaiLoi })
            {
                chart.BackColor = bgColor;
                chart.Legends.Clear();
                var area = chart.ChartAreas[0];
                area.BackColor = bgColor;
                area.AxisX.Interval = 1;
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                area.AxisX.LabelStyle.ForeColor = Color.White;
                area.AxisX.IsMarginVisible = false; // Important to remove extra padding on X axis (which is vertical for horizontal bar chart)
                
                area.AxisY.LabelStyle.ForeColor = Color.Transparent; // Hide Y axis labels
                area.AxisY.MajorGrid.LineColor = gridColor;
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisY.MajorTickMark.Enabled = false;
                area.AxisX.MajorTickMark.Enabled = false;
                area.AxisX.LineColor = Color.Transparent;
                area.AxisY.LineColor = gridColor;
                
                // Increase thickness of bars
                chart.Series[0]["PointWidth"] = "0.75";
            }
            
            // Specifically adjust chartTienDo to use all available horizontal space
            var areaTienDo = chartTienDo.ChartAreas[0];
            areaTienDo.AxisY.Maximum = 1250; // Set explicit max to fill space well
            
            // Adjust label positions
            chartTienDo.Series[0].CustomProperties = "BarLabelStyle=Outside";
            chartPhanLoaiLoi.Series[0].CustomProperties = "BarLabelStyle=Outside";

            // Optimize margins for the main chart
            areaTienDo.Position.Auto = false;
            areaTienDo.Position = new ElementPosition(0, 0, 100, 100);
            areaTienDo.InnerPlotPosition.Auto = false;
            areaTienDo.InnerPlotPosition = new ElementPosition(20, 0, 70, 100); // (X, Y, Width, Height) in percentage
            
            // For chartPhanLoaiLoi
            var areaLoi = chartPhanLoaiLoi.ChartAreas[0];
            areaLoi.AxisY.Maximum = 11;
            areaLoi.Position.Auto = false;
            areaLoi.Position = new ElementPosition(0, 0, 100, 100);
            areaLoi.InnerPlotPosition.Auto = false;
            areaLoi.InnerPlotPosition = new ElementPosition(35, 5, 55, 90);
            
            // For chartNhipSanXuat
            var areaNhip = chartNhipSanXuat.ChartAreas[0];
            areaNhip.AxisX.IsMarginVisible = true; // For column chart, margins are okay so columns aren't cut on edges
            areaNhip.Position.Auto = false;
            areaNhip.Position = new ElementPosition(0, 0, 100, 100);
            areaNhip.InnerPlotPosition.Auto = false;
            areaNhip.InnerPlotPosition = new ElementPosition(5, 10, 90, 80);

            // For chartTiLeHoanThanh and pnlCard3 layout
            chartTiLeHoanThanh.Legends.Clear();
            var areaTiLe = chartTiLeHoanThanh.ChartAreas[0];
            areaTiLe.Position.Auto = false;
            areaTiLe.Position = new ElementPosition(0, 0, 100, 100);
            areaTiLe.InnerPlotPosition.Auto = false;
            areaTiLe.InnerPlotPosition = new ElementPosition(0, 0, 100, 100);
            chartTiLeHoanThanh.Series[0]["DoughnutRadius"] = "80"; // Thinner ring

            // Make colors match
            chartTiLeHoanThanh.Series[0].Points[0].Color = ColorTranslator.FromHtml("#53C38C");
            chartTiLeHoanThanh.Series[0].Points[1].Color = Color.FromArgb(40, 40, 40);

            // We will use StyleCard for the left border and icon

            // Reposition Title
            lblCard3Title.Location = new Point(15, 12);
            lblCard3Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCard3Title.ForeColor = Color.LightGray;

            // Chart positioning
            chartTiLeHoanThanh.Size = new Size(65, 65);
            chartTiLeHoanThanh.Location = new Point(15, 33);
            chartTiLeHoanThanh.Margin = new Padding(0);

            // Put % Label inside chart
            lblCard3Value.Parent = chartTiLeHoanThanh;
            lblCard3Value.BackColor = Color.Transparent;
            lblCard3Value.AutoSize = false;
            lblCard3Value.Size = new Size(65, 65);
            lblCard3Value.Location = new Point(0, 0);
            lblCard3Value.TextAlign = ContentAlignment.MiddleCenter;
            lblCard3Value.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            // Hide old sub label
            lblCard3Sub.Visible = false;

            // New labels to right of chart
            Label lblProgTitle = new Label();
            lblProgTitle.Text = "Tiến độ ngày";
            lblProgTitle.ForeColor = Color.DarkGray;
            lblProgTitle.Font = new Font("Segoe UI", 8F);
            lblProgTitle.Location = new Point(90, 35);
            lblProgTitle.AutoSize = true;

            Label lblProgVal = new Label();
            lblProgVal.Text = "842 / 1.250";
            lblProgVal.ForeColor = Color.White;
            lblProgVal.Font = new Font("Consolas", 10F); // Monospaced for numbers
            lblProgVal.Location = new Point(90, 52);
            lblProgVal.AutoSize = true;

            Label lblProgExp = new Label();
            lblProgExp.Text = "Kỳ vọng giờ này: 71%";
            lblProgExp.ForeColor = Color.DimGray;
            lblProgExp.Font = new Font("Segoe UI", 8F);
            lblProgExp.Location = new Point(90, 75);
            lblProgExp.AutoSize = true;

            pnlCard3.Controls.Add(lblProgTitle);
            pnlCard3.Controls.Add(lblProgVal);
            pnlCard3.Controls.Add(lblProgExp);

            // Alerts Title styling
            lblAlertsTitle.Text = "\uD83D\uDD14 CẢNH BÁO ĐANG MỞ"; // Bell emoji
            lblAlertsTitle.ForeColor = Color.LightGray;

            // Add red badge "4"
            Label badge = new Label();
            badge.Text = "4";
            badge.ForeColor = Color.White;
            badge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            badge.BackColor = ColorTranslator.FromHtml("#E55F60"); // colorRed
            badge.AutoSize = false;
            badge.Size = new Size(24, 24);
            badge.TextAlign = ContentAlignment.MiddleCenter;
            badge.Location = new Point(pnlAlerts.Width - 35, 12);
            badge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            
            badge.Paint += (s, e) => {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddEllipse(0, 0, badge.Width - 1, badge.Height - 1);
                    badge.Region = new Region(path);
                }
            };
            pnlAlerts.Controls.Add(badge);

            // Apply card styling (left border + icon)
            StyleCard(pnlCard1, ColorTranslator.FromHtml("#DE9F4D"), "\u25CE"); // Orange target
            StyleCard(pnlCard2, ColorTranslator.FromHtml("#53C38C"), "\u2713"); // Green check
            StyleCard(pnlCard3, ColorTranslator.FromHtml("#53C38C"), "\u25D4"); // Green pie
            StyleCard(pnlCard4, ColorTranslator.FromHtml("#E55F60"), "\u26A0"); // Red warning
            StyleCard(pnlCard5, ColorTranslator.FromHtml("#DE9F4D"), "\u2696"); // Orange scale
        }

        private Panel CreateAlertPanel(string title, string sub, string val, Color valColor, string iconChar, string thresholdText, string timeStr)
        {
            Panel p = new Panel();
            p.Width = flpAlerts.ClientSize.Width > 0 ? flpAlerts.ClientSize.Width - 25 : 320;
            p.Height = 85;
            p.Margin = new Padding(10, 0, 10, 10);
            p.BackColor = Color.FromArgb(20, valColor.R, valColor.G, valColor.B); // Tinted background

            // Add thin colored border via Paint event
            p.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(100, valColor.R, valColor.G, valColor.B), 1))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        int r = 10;
                        path.AddArc(0, 0, r, r, 180, 90);
                        path.AddArc(p.Width - r - 1, 0, r, r, 270, 90);
                        path.AddArc(p.Width - r - 1, p.Height - r - 1, r, r, 0, 90);
                        path.AddArc(0, p.Height - r - 1, r, r, 90, 90);
                        path.CloseFigure();
                        e.Graphics.DrawPath(pen, path);
                        p.Region = new Region(path); // round corners for the panel
                    }
                }
            };

            // Icon background
            Label iconBg = new Label();
            iconBg.Text = iconChar;
            iconBg.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Regular);
            iconBg.ForeColor = valColor;
            iconBg.AutoSize = false;
            iconBg.Size = new Size(36, 36);
            iconBg.Location = new Point(15, 24);
            iconBg.TextAlign = ContentAlignment.MiddleCenter;
            iconBg.BackColor = Color.FromArgb(30, valColor.R, valColor.G, valColor.B);
            
            iconBg.Paint += (s, e) => {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 10;
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(iconBg.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(iconBg.Width - radius, iconBg.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, iconBg.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    iconBg.Region = new Region(path);
                }
            };
            p.Controls.Add(iconBg);

            // Title
            Label lblT = new Label();
            lblT.Text = title;
            lblT.ForeColor = Color.White;
            lblT.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblT.Location = new Point(65, 12);
            lblT.AutoSize = true;

            // Subtitle
            Label lblS = new Label();
            lblS.Text = sub;
            lblS.ForeColor = Color.DarkGray;
            lblS.Font = new Font("Segoe UI", 8);
            lblS.Location = new Point(65, 36);
            lblS.AutoSize = true;
            lblS.MaximumSize = new Size(160, 40); // wrap text if needed

            // Value
            Label lblV = new Label();
            lblV.Text = val;
            lblV.ForeColor = valColor;
            lblV.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblV.AutoSize = true;
            p.Controls.Add(lblV); // Add to get width
            lblV.Location = new Point(p.Width - lblV.PreferredWidth - 15, 12);
            lblV.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Threshold text
            Label lblThresh = new Label();
            lblThresh.Text = thresholdText;
            lblThresh.ForeColor = Color.DimGray;
            lblThresh.Font = new Font("Segoe UI", 8);
            lblThresh.AutoSize = true;
            p.Controls.Add(lblThresh);
            lblThresh.Location = new Point(p.Width - lblThresh.PreferredWidth - 15, lblV.Bottom);
            lblThresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Time text
            Label lblTime = new Label();
            lblTime.Text = "\u23F2 " + timeStr;
            lblTime.ForeColor = Color.DimGray;
            lblTime.Font = new Font("Segoe UI", 8);
            lblTime.AutoSize = true;
            p.Controls.Add(lblTime);
            lblTime.Location = new Point(p.Width - lblTime.PreferredWidth - 15, lblThresh.Bottom + 2);
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            p.Controls.Add(lblT);
            p.Controls.Add(lblS);

            return p;
        }

        private void FlpAlerts_Resize(object sender, EventArgs e)
        {
            int w = flpAlerts.ClientSize.Width;
            foreach (Control c in flpAlerts.Controls)
            {
                c.Width = w - c.Margin.Left - c.Margin.Right;
            }
        }

        private void StyleCard(Panel card, Color accentColor, string iconChar)
        {
            // Left border
            Panel leftBorder = new Panel();
            leftBorder.Width = 4;
            leftBorder.Dock = DockStyle.Left;
            leftBorder.BackColor = accentColor;
            card.Controls.Add(leftBorder);

            // Icon background
            Label iconLabel = new Label();
            iconLabel.Text = iconChar;
            iconLabel.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular);
            iconLabel.ForeColor = accentColor;
            iconLabel.AutoSize = false;
            iconLabel.Size = new Size(32, 32);
            iconLabel.Location = new Point(card.Width - 45, 12);
            iconLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconLabel.TextAlign = ContentAlignment.MiddleCenter;
            iconLabel.BackColor = Color.FromArgb(40, accentColor.R, accentColor.G, accentColor.B);
            
            // Rounded corners for icon
            iconLabel.Paint += (s, e) => {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 8;
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(iconLabel.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(iconLabel.Width - radius, iconLabel.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, iconLabel.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    iconLabel.Region = new Region(path);
                }
            };
            card.Controls.Add(iconLabel);

            // Shift existing elements to the right to make space for the left border if they are too close
            foreach (Control c in card.Controls)
            {
                if (c != leftBorder && c != iconLabel && c.Location.X <= 10)
                {
                    c.Location = new Point(15, c.Location.Y);
                }
            }
        }
    }
}
