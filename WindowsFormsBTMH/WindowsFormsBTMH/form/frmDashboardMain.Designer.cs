namespace WindowsFormsBTMH.form
{
    partial class DashboardMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainTlp = new System.Windows.Forms.TableLayoutPanel();
            this.headerTlp = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cardsTlp = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Sub = new System.Windows.Forms.Label();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Sub = new System.Windows.Forms.Label();
            this.lblCard2Value = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.chartTiLeHoanThanh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCard3Sub = new System.Windows.Forms.Label();
            this.lblCard3Value = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblCard4Sub = new System.Windows.Forms.Label();
            this.lblCard4Value = new System.Windows.Forms.Label();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.pnlCard5 = new System.Windows.Forms.Panel();
            this.lblCard5Sub = new System.Windows.Forms.Label();
            this.lblCard5Value = new System.Windows.Forms.Label();
            this.lblCard5Title = new System.Windows.Forms.Label();
            this.middleTlp = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.chartTienDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblProgressTitle = new System.Windows.Forms.Label();
            this.pnlAlerts = new System.Windows.Forms.Panel();
            this.flpAlerts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAlertsTitle = new System.Windows.Forms.Label();
            this.bottomTlp = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPace = new System.Windows.Forms.Panel();
            this.chartNhipSanXuat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPaceTitle = new System.Windows.Forms.Label();
            this.pnlDefects = new System.Windows.Forms.Panel();
            this.chartPhanLoaiLoi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDefectsTitle = new System.Windows.Forms.Label();
            this.mainTlp.SuspendLayout();
            this.headerTlp.SuspendLayout();
            this.cardsTlp.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiLeHoanThanh)).BeginInit();
            this.pnlCard4.SuspendLayout();
            this.pnlCard5.SuspendLayout();
            this.middleTlp.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTienDo)).BeginInit();
            this.pnlAlerts.SuspendLayout();
            this.bottomTlp.SuspendLayout();
            this.pnlPace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhipSanXuat)).BeginInit();
            this.pnlDefects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhanLoaiLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTlp
            // 
            this.mainTlp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(19)))));
            this.mainTlp.ColumnCount = 1;
            this.mainTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTlp.Controls.Add(this.headerTlp, 0, 0);
            this.mainTlp.Controls.Add(this.cardsTlp, 0, 1);
            this.mainTlp.Controls.Add(this.middleTlp, 0, 2);
            this.mainTlp.Controls.Add(this.bottomTlp, 0, 3);
            this.mainTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTlp.Location = new System.Drawing.Point(0, 0);
            this.mainTlp.Name = "mainTlp";
            this.mainTlp.Padding = new System.Windows.Forms.Padding(10);
            this.mainTlp.RowCount = 4;
            this.mainTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.mainTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.mainTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainTlp.Size = new System.Drawing.Size(1449, 800);
            this.mainTlp.TabIndex = 0;
            // 
            // headerTlp
            // 
            this.headerTlp.ColumnCount = 3;
            this.headerTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.headerTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.headerTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.headerTlp.Controls.Add(this.lblLogo, 0, 0);
            this.headerTlp.Controls.Add(this.lblMainTitle, 1, 0);
            this.headerTlp.Controls.Add(this.lblTime, 2, 0);
            this.headerTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTlp.Location = new System.Drawing.Point(13, 13);
            this.headerTlp.Name = "headerTlp";
            this.headerTlp.RowCount = 1;
            this.headerTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTlp.Size = new System.Drawing.Size(1423, 64);
            this.headerTlp.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblLogo.Location = new System.Drawing.Point(3, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(420, 64);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "[BTMH] Bảo Tín Mạnh Hải\nMES - Quản lý sản xuất vàng && trang sức";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(429, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(563, 64);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "BẢNG ĐIỀU KHIỂN SẢN XUẤT\nTổng quan toàn xưởng - Realtime";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblTime.Location = new System.Drawing.Point(998, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(422, 64);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "CA LÀM VIỆC\nCa ngày - 07:00-17:00\n23:34:42";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cardsTlp
            // 
            this.cardsTlp.ColumnCount = 5;
            this.cardsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardsTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cardsTlp.Controls.Add(this.pnlCard1, 0, 0);
            this.cardsTlp.Controls.Add(this.pnlCard2, 1, 0);
            this.cardsTlp.Controls.Add(this.pnlCard3, 2, 0);
            this.cardsTlp.Controls.Add(this.pnlCard4, 3, 0);
            this.cardsTlp.Controls.Add(this.pnlCard5, 4, 0);
            this.cardsTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardsTlp.Location = new System.Drawing.Point(13, 83);
            this.cardsTlp.Name = "cardsTlp";
            this.cardsTlp.RowCount = 1;
            this.cardsTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardsTlp.Size = new System.Drawing.Size(1423, 114);
            this.cardsTlp.TabIndex = 1;
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCard1.Controls.Add(this.lblCard1Sub);
            this.pnlCard1.Controls.Add(this.lblCard1Value);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard1.Location = new System.Drawing.Point(5, 5);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(274, 104);
            this.pnlCard1.TabIndex = 0;
            // 
            // lblCard1Sub
            // 
            this.lblCard1Sub.AutoSize = true;
            this.lblCard1Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard1Sub.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCard1Sub.Location = new System.Drawing.Point(10, 80);
            this.lblCard1Sub.Name = "lblCard1Sub";
            this.lblCard1Sub.Size = new System.Drawing.Size(154, 15);
            this.lblCard1Sub.TabIndex = 0;
            this.lblCard1Sub.Text = "Mục tiêu trong ngày - 9 LSX";
            // 
            // lblCard1Value
            // 
            this.lblCard1Value.AutoSize = true;
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value.ForeColor = System.Drawing.Color.White;
            this.lblCard1Value.Location = new System.Drawing.Point(10, 35);
            this.lblCard1Value.Name = "lblCard1Value";
            this.lblCard1Value.Size = new System.Drawing.Size(144, 45);
            this.lblCard1Value.TabIndex = 1;
            this.lblCard1Value.Text = "1.250 sp";
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard1Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard1Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(129, 19);
            this.lblCard1Title.TabIndex = 2;
            this.lblCard1Title.Text = "Sản lượng kế hoạch";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCard2.Controls.Add(this.lblCard2Sub);
            this.pnlCard2.Controls.Add(this.lblCard2Value);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard2.Location = new System.Drawing.Point(289, 5);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(274, 104);
            this.pnlCard2.TabIndex = 1;
            // 
            // lblCard2Sub
            // 
            this.lblCard2Sub.AutoSize = true;
            this.lblCard2Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard2Sub.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCard2Sub.Location = new System.Drawing.Point(10, 80);
            this.lblCard2Sub.Name = "lblCard2Sub";
            this.lblCard2Sub.Size = new System.Drawing.Size(121, 15);
            this.lblCard2Sub.TabIndex = 0;
            this.lblCard2Sub.Text = "▲ +119 trong giờ qua";
            // 
            // lblCard2Value
            // 
            this.lblCard2Value.AutoSize = true;
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value.ForeColor = System.Drawing.Color.White;
            this.lblCard2Value.Location = new System.Drawing.Point(10, 35);
            this.lblCard2Value.Name = "lblCard2Value";
            this.lblCard2Value.Size = new System.Drawing.Size(117, 45);
            this.lblCard2Value.TabIndex = 1;
            this.lblCard2Value.Text = "842 sp";
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard2Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(101, 19);
            this.lblCard2Title.TabIndex = 2;
            this.lblCard2Title.Text = "Đã hoàn thành";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCard3.Controls.Add(this.chartTiLeHoanThanh);
            this.pnlCard3.Controls.Add(this.lblCard3Sub);
            this.pnlCard3.Controls.Add(this.lblCard3Value);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard3.Location = new System.Drawing.Point(573, 5);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(274, 104);
            this.pnlCard3.TabIndex = 2;
            // 
            // chartTiLeHoanThanh
            // 
            this.chartTiLeHoanThanh.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chartTiLeHoanThanh.ChartAreas.Add(chartArea1);
            this.chartTiLeHoanThanh.Location = new System.Drawing.Point(151, 10);
            this.chartTiLeHoanThanh.Name = "chartTiLeHoanThanh";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Name = "Series1";
            this.chartTiLeHoanThanh.Series.Add(series1);
            this.chartTiLeHoanThanh.Size = new System.Drawing.Size(100, 85);
            this.chartTiLeHoanThanh.TabIndex = 3;
            // 
            // lblCard3Sub
            // 
            this.lblCard3Sub.AutoSize = true;
            this.lblCard3Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard3Sub.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCard3Sub.Location = new System.Drawing.Point(10, 80);
            this.lblCard3Sub.Name = "lblCard3Sub";
            this.lblCard3Sub.Size = new System.Drawing.Size(135, 15);
            this.lblCard3Sub.TabIndex = 4;
            this.lblCard3Sub.Text = "Tiến độ ngày 842 / 1.250";
            // 
            // lblCard3Value
            // 
            this.lblCard3Value.AutoSize = true;
            this.lblCard3Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard3Value.ForeColor = System.Drawing.Color.White;
            this.lblCard3Value.Location = new System.Drawing.Point(10, 35);
            this.lblCard3Value.Name = "lblCard3Value";
            this.lblCard3Value.Size = new System.Drawing.Size(84, 45);
            this.lblCard3Value.TabIndex = 5;
            this.lblCard3Value.Text = "67%";
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard3Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard3Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(108, 19);
            this.lblCard3Title.TabIndex = 6;
            this.lblCard3Title.Text = "Tỉ lệ hoàn thành";
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCard4.Controls.Add(this.lblCard4Sub);
            this.pnlCard4.Controls.Add(this.lblCard4Value);
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard4.Location = new System.Drawing.Point(857, 5);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(274, 104);
            this.pnlCard4.TabIndex = 3;
            // 
            // lblCard4Sub
            // 
            this.lblCard4Sub.AutoSize = true;
            this.lblCard4Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard4Sub.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCard4Sub.Location = new System.Drawing.Point(10, 80);
            this.lblCard4Sub.Name = "lblCard4Sub";
            this.lblCard4Sub.Size = new System.Drawing.Size(155, 15);
            this.lblCard4Sub.TabIndex = 0;
            this.lblCard4Sub.Text = "2.7% tỉ lệ NG - ngưỡng 4.0%";
            // 
            // lblCard4Value
            // 
            this.lblCard4Value.AutoSize = true;
            this.lblCard4Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard4Value.ForeColor = System.Drawing.Color.White;
            this.lblCard4Value.Location = new System.Drawing.Point(10, 35);
            this.lblCard4Value.Name = "lblCard4Value";
            this.lblCard4Value.Size = new System.Drawing.Size(99, 45);
            this.lblCard4Value.TabIndex = 1;
            this.lblCard4Value.Text = "23 sp";
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.AutoSize = true;
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard4Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard4Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(122, 19);
            this.lblCard4Title.TabIndex = 2;
            this.lblCard4Title.Text = "Sản phẩm lỗi - NG";
            // 
            // pnlCard5
            // 
            this.pnlCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCard5.Controls.Add(this.lblCard5Sub);
            this.pnlCard5.Controls.Add(this.lblCard5Value);
            this.pnlCard5.Controls.Add(this.lblCard5Title);
            this.pnlCard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard5.Location = new System.Drawing.Point(1141, 5);
            this.pnlCard5.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard5.Name = "pnlCard5";
            this.pnlCard5.Size = new System.Drawing.Size(277, 104);
            this.pnlCard5.TabIndex = 4;
            // 
            // lblCard5Sub
            // 
            this.lblCard5Sub.AutoSize = true;
            this.lblCard5Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCard5Sub.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCard5Sub.Location = new System.Drawing.Point(10, 80);
            this.lblCard5Sub.Name = "lblCard5Sub";
            this.lblCard5Sub.Size = new System.Drawing.Size(162, 15);
            this.lblCard5Sub.TabIndex = 0;
            this.lblCard5Sub.Text = "⚠ Lệch chuẩn ngưỡng 0.35%";
            // 
            // lblCard5Value
            // 
            this.lblCard5Value.AutoSize = true;
            this.lblCard5Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard5Value.ForeColor = System.Drawing.Color.White;
            this.lblCard5Value.Location = new System.Drawing.Point(10, 35);
            this.lblCard5Value.Name = "lblCard5Value";
            this.lblCard5Value.Size = new System.Drawing.Size(120, 45);
            this.lblCard5Value.TabIndex = 1;
            this.lblCard5Value.Text = "0,42 %";
            // 
            // lblCard5Title
            // 
            this.lblCard5Title.AutoSize = true;
            this.lblCard5Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard5Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard5Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard5Title.Name = "lblCard5Title";
            this.lblCard5Title.Size = new System.Drawing.Size(93, 19);
            this.lblCard5Title.TabIndex = 2;
            this.lblCard5Title.Text = "Hao hụt vàng";
            // 
            // middleTlp
            // 
            this.middleTlp.ColumnCount = 2;
            this.middleTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.middleTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.middleTlp.Controls.Add(this.pnlProgress, 0, 0);
            this.middleTlp.Controls.Add(this.pnlAlerts, 1, 0);
            this.middleTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleTlp.Location = new System.Drawing.Point(13, 203);
            this.middleTlp.Name = "middleTlp";
            this.middleTlp.RowCount = 1;
            this.middleTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleTlp.Size = new System.Drawing.Size(1423, 318);
            this.middleTlp.TabIndex = 2;
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlProgress.Controls.Add(this.chartTienDo);
            this.pnlProgress.Controls.Add(this.lblProgressTitle);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProgress.Location = new System.Drawing.Point(5, 5);
            this.pnlProgress.Margin = new System.Windows.Forms.Padding(5);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(986, 308);
            this.pnlProgress.TabIndex = 0;
            // 
            // chartTienDo
            // 
            this.chartTienDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTienDo.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartTienDo.ChartAreas.Add(chartArea2);
            this.chartTienDo.Location = new System.Drawing.Point(0, 45);
            this.chartTienDo.Name = "chartTienDo";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Name = "Series1";
            this.chartTienDo.Series.Add(series2);
            this.chartTienDo.Size = new System.Drawing.Size(983, 260);
            this.chartTienDo.TabIndex = 0;
            // 
            // lblProgressTitle
            // 
            this.lblProgressTitle.AutoSize = true;
            this.lblProgressTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProgressTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProgressTitle.Location = new System.Drawing.Point(15, 15);
            this.lblProgressTitle.Name = "lblProgressTitle";
            this.lblProgressTitle.Size = new System.Drawing.Size(325, 20);
            this.lblProgressTitle.TabIndex = 1;
            this.lblProgressTitle.Text = "TIẾN ĐỘ THEO CÔNG ĐOẠN - TOÀN XƯỞNG";
            // 
            // pnlAlerts
            // 
            this.pnlAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlAlerts.Controls.Add(this.flpAlerts);
            this.pnlAlerts.Controls.Add(this.lblAlertsTitle);
            this.pnlAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlerts.Location = new System.Drawing.Point(1001, 5);
            this.pnlAlerts.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAlerts.Name = "pnlAlerts";
            this.pnlAlerts.Size = new System.Drawing.Size(417, 308);
            this.pnlAlerts.TabIndex = 1;
            // 
            // flpAlerts
            // 
            this.flpAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAlerts.AutoScroll = true;
            this.flpAlerts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAlerts.Location = new System.Drawing.Point(0, 45);
            this.flpAlerts.Name = "flpAlerts";
            this.flpAlerts.Size = new System.Drawing.Size(414, 260);
            this.flpAlerts.TabIndex = 0;
            this.flpAlerts.WrapContents = false;
            // 
            // lblAlertsTitle
            // 
            this.lblAlertsTitle.AutoSize = true;
            this.lblAlertsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlertsTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAlertsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblAlertsTitle.Name = "lblAlertsTitle";
            this.lblAlertsTitle.Size = new System.Drawing.Size(167, 20);
            this.lblAlertsTitle.TabIndex = 1;
            this.lblAlertsTitle.Text = "CẢNH BÁO ĐANG MỞ";
            // 
            // bottomTlp
            // 
            this.bottomTlp.ColumnCount = 2;
            this.bottomTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.bottomTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.bottomTlp.Controls.Add(this.pnlPace, 0, 0);
            this.bottomTlp.Controls.Add(this.pnlDefects, 1, 0);
            this.bottomTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTlp.Location = new System.Drawing.Point(13, 527);
            this.bottomTlp.Name = "bottomTlp";
            this.bottomTlp.RowCount = 1;
            this.bottomTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTlp.Size = new System.Drawing.Size(1423, 260);
            this.bottomTlp.TabIndex = 3;
            // 
            // pnlPace
            // 
            this.pnlPace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlPace.Controls.Add(this.chartNhipSanXuat);
            this.pnlPace.Controls.Add(this.lblPaceTitle);
            this.pnlPace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPace.Location = new System.Drawing.Point(5, 5);
            this.pnlPace.Margin = new System.Windows.Forms.Padding(5);
            this.pnlPace.Name = "pnlPace";
            this.pnlPace.Size = new System.Drawing.Size(986, 250);
            this.pnlPace.TabIndex = 0;
            // 
            // chartNhipSanXuat
            // 
            this.chartNhipSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartNhipSanXuat.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartNhipSanXuat.ChartAreas.Add(chartArea3);
            this.chartNhipSanXuat.Location = new System.Drawing.Point(0, 45);
            this.chartNhipSanXuat.Name = "chartNhipSanXuat";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chartNhipSanXuat.Series.Add(series3);
            this.chartNhipSanXuat.Size = new System.Drawing.Size(983, 202);
            this.chartNhipSanXuat.TabIndex = 0;
            // 
            // lblPaceTitle
            // 
            this.lblPaceTitle.AutoSize = true;
            this.lblPaceTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPaceTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPaceTitle.Location = new System.Drawing.Point(15, 15);
            this.lblPaceTitle.Name = "lblPaceTitle";
            this.lblPaceTitle.Size = new System.Drawing.Size(201, 20);
            this.lblPaceTitle.TabIndex = 1;
            this.lblPaceTitle.Text = "NHỊP SẢN XUẤT THEO GIỜ";
            // 
            // pnlDefects
            // 
            this.pnlDefects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlDefects.Controls.Add(this.chartPhanLoaiLoi);
            this.pnlDefects.Controls.Add(this.lblDefectsTitle);
            this.pnlDefects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDefects.Location = new System.Drawing.Point(1001, 5);
            this.pnlDefects.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDefects.Name = "pnlDefects";
            this.pnlDefects.Size = new System.Drawing.Size(417, 250);
            this.pnlDefects.TabIndex = 1;
            // 
            // chartPhanLoaiLoi
            // 
            this.chartPhanLoaiLoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPhanLoaiLoi.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartPhanLoaiLoi.ChartAreas.Add(chartArea4);
            this.chartPhanLoaiLoi.Location = new System.Drawing.Point(0, 45);
            this.chartPhanLoaiLoi.Name = "chartPhanLoaiLoi";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Name = "Series1";
            this.chartPhanLoaiLoi.Series.Add(series4);
            this.chartPhanLoaiLoi.Size = new System.Drawing.Size(417, 202);
            this.chartPhanLoaiLoi.TabIndex = 0;
            // 
            // lblDefectsTitle
            // 
            this.lblDefectsTitle.AutoSize = true;
            this.lblDefectsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDefectsTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDefectsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDefectsTitle.Name = "lblDefectsTitle";
            this.lblDefectsTitle.Size = new System.Drawing.Size(194, 20);
            this.lblDefectsTitle.TabIndex = 1;
            this.lblDefectsTitle.Text = "PHÂN LOẠI LỖI HÔM NAY";
            // 
            // DashboardMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 800);
            this.Controls.Add(this.mainTlp);
            this.Name = "DashboardMain";
            this.Text = "DashboardMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTlp.ResumeLayout(false);
            this.headerTlp.ResumeLayout(false);
            this.headerTlp.PerformLayout();
            this.cardsTlp.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiLeHoanThanh)).EndInit();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.pnlCard5.ResumeLayout(false);
            this.pnlCard5.PerformLayout();
            this.middleTlp.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTienDo)).EndInit();
            this.pnlAlerts.ResumeLayout(false);
            this.pnlAlerts.PerformLayout();
            this.bottomTlp.ResumeLayout(false);
            this.pnlPace.ResumeLayout(false);
            this.pnlPace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhipSanXuat)).EndInit();
            this.pnlDefects.ResumeLayout(false);
            this.pnlDefects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhanLoaiLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTlp;
        private System.Windows.Forms.TableLayoutPanel headerTlp;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TableLayoutPanel cardsTlp;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Label lblCard1Sub;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Value;
        private System.Windows.Forms.Label lblCard2Sub;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Value;
        private System.Windows.Forms.Label lblCard3Sub;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Label lblCard4Value;
        private System.Windows.Forms.Label lblCard4Sub;
        private System.Windows.Forms.Panel pnlCard5;
        private System.Windows.Forms.Label lblCard5Title;
        private System.Windows.Forms.Label lblCard5Value;
        private System.Windows.Forms.Label lblCard5Sub;
        private System.Windows.Forms.TableLayoutPanel middleTlp;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblProgressTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTienDo;
        private System.Windows.Forms.Panel pnlAlerts;
        private System.Windows.Forms.Label lblAlertsTitle;
        private System.Windows.Forms.FlowLayoutPanel flpAlerts;
        private System.Windows.Forms.TableLayoutPanel bottomTlp;
        private System.Windows.Forms.Panel pnlPace;
        private System.Windows.Forms.Label lblPaceTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNhipSanXuat;
        private System.Windows.Forms.Panel pnlDefects;
        private System.Windows.Forms.Label lblDefectsTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhanLoaiLoi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiLeHoanThanh;
    }
}
