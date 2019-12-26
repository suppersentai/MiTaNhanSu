namespace testmultithread
{
    partial class NhanSu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanSu));
            this.panMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabIcon = new System.Windows.Forms.TabPage();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChuaDongBo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTextWaitting = new DevComponents.DotNetBar.LabelX();
            this.btnSync = new System.Windows.Forms.Button();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.lbCountMachine = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lbCountConnected = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lbCountNotConnect = new DevComponents.DotNetBar.LabelX();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.lbTimer = new DevComponents.DotNetBar.LabelX();
            this.txtTimeSpan = new System.Windows.Forms.TextBox();
            this.lbTextKiemTraSau = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeSyncAuto = new System.Windows.Forms.Timer(this.components);
            this.panMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabIcon.SuspendLayout();
            this.flowLayout.SuspendLayout();
            this.tabGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panel2);
            this.panMain.Controls.Add(this.panel1);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1666, 885);
            this.panMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tab);
            this.panel2.Location = new System.Drawing.Point(368, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 880);
            this.panel2.TabIndex = 6;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabIcon);
            this.tab.Controls.Add(this.tabGrid);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1294, 876);
            this.tab.TabIndex = 5;
            // 
            // tabIcon
            // 
            this.tabIcon.Controls.Add(this.flowLayout);
            this.tabIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabIcon.Location = new System.Drawing.Point(4, 29);
            this.tabIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabIcon.Name = "tabIcon";
            this.tabIcon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabIcon.Size = new System.Drawing.Size(1286, 843);
            this.tabIcon.TabIndex = 0;
            this.tabIcon.Text = "Kiểu 1";
            this.tabIcon.UseVisualStyleBackColor = true;
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Controls.Add(this.label1);
            this.flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout.Location = new System.Drawing.Point(3, 4);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(1280, 835);
            this.flowLayout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(281, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(281, 62, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chưa có dữ liệu. Vui lòng cập nhật lại ";
            // 
            // tabGrid
            // 
            this.tabGrid.Controls.Add(this.dgv);
            this.tabGrid.Location = new System.Drawing.Point(4, 29);
            this.tabGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGrid.Size = new System.Drawing.Size(1286, 843);
            this.tabGrid.TabIndex = 1;
            this.tabGrid.Text = "Kiểu 2";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStt,
            this.clMaMay,
            this.clTenMay,
            this.clTrangThai,
            this.clChuaDongBo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(3, 4);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(1280, 835);
            this.dgv.TabIndex = 3;
            // 
            // clStt
            // 
            this.clStt.FillWeight = 50F;
            this.clStt.HeaderText = "Stt";
            this.clStt.MaxInputLength = 111;
            this.clStt.MinimumWidth = 10;
            this.clStt.Name = "clStt";
            this.clStt.ReadOnly = true;
            // 
            // clMaMay
            // 
            this.clMaMay.FillWeight = 91.57755F;
            this.clMaMay.HeaderText = "Mã máy";
            this.clMaMay.MinimumWidth = 6;
            this.clMaMay.Name = "clMaMay";
            this.clMaMay.ReadOnly = true;
            // 
            // clTenMay
            // 
            this.clTenMay.FillWeight = 91.57755F;
            this.clTenMay.HeaderText = "Tên máy";
            this.clTenMay.MinimumWidth = 6;
            this.clTenMay.Name = "clTenMay";
            this.clTenMay.ReadOnly = true;
            // 
            // clTrangThai
            // 
            this.clTrangThai.FillWeight = 91.57755F;
            this.clTrangThai.HeaderText = "Trang thái";
            this.clTrangThai.MinimumWidth = 6;
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.ReadOnly = true;
            // 
            // clChuaDongBo
            // 
            this.clChuaDongBo.FillWeight = 91.57755F;
            this.clChuaDongBo.HeaderText = "Chưa đồng bộ";
            this.clChuaDongBo.MinimumWidth = 6;
            this.clChuaDongBo.Name = "clChuaDongBo";
            this.clChuaDongBo.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbTextWaitting);
            this.panel1.Controls.Add(this.btnSync);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX7);
            this.panel1.Controls.Add(this.lbCountMachine);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.lbCountConnected);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.lbCountNotConnect);
            this.panel1.Controls.Add(this.metroToggle1);
            this.panel1.Controls.Add(this.lbTimer);
            this.panel1.Controls.Add(this.txtTimeSpan);
            this.panel1.Controls.Add(this.lbTextKiemTraSau);
            this.panel1.Controls.Add(this.labelX9);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 892);
            this.panel1.TabIndex = 3;
            // 
            // lbTextWaitting
            // 
            // 
            // 
            // 
            this.lbTextWaitting.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTextWaitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextWaitting.ForeColor = System.Drawing.Color.Red;
            this.lbTextWaitting.Location = new System.Drawing.Point(21, 458);
            this.lbTextWaitting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTextWaitting.Name = "lbTextWaitting";
            this.lbTextWaitting.Size = new System.Drawing.Size(330, 29);
            this.lbTextWaitting.TabIndex = 47;
            this.lbTextWaitting.Text = "0";
            this.lbTextWaitting.Click += new System.EventHandler(this.lbTextWaitting_Click);
            // 
            // btnSync
            // 
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(78, 558);
            this.btnSync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(202, 65);
            this.btnSync.TabIndex = 9;
            this.btnSync.Text = "     Cập nhật ";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(21, 215);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(127, 29);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Mất kết nối";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(21, 111);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 29);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tổng máy";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(21, 160);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(143, 29);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Đã đồng bộ";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(307, 359);
            this.labelX7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(61, 29);
            this.labelX7.TabIndex = 46;
            this.labelX7.Text = "phút";
            // 
            // lbCountMachine
            // 
            // 
            // 
            // 
            this.lbCountMachine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCountMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountMachine.Location = new System.Drawing.Point(231, 111);
            this.lbCountMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbCountMachine.Name = "lbCountMachine";
            this.lbCountMachine.Size = new System.Drawing.Size(50, 30);
            this.lbCountMachine.TabIndex = 4;
            this.lbCountMachine.Text = "0";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(21, 361);
            this.labelX6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(107, 29);
            this.labelX6.TabIndex = 45;
            this.labelX6.Text = "Sau";
            // 
            // lbCountConnected
            // 
            // 
            // 
            // 
            this.lbCountConnected.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCountConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbCountConnected.Location = new System.Drawing.Point(231, 160);
            this.lbCountConnected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbCountConnected.Name = "lbCountConnected";
            this.lbCountConnected.Size = new System.Drawing.Size(50, 29);
            this.lbCountConnected.TabIndex = 5;
            this.lbCountConnected.Text = "0";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(21, 306);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(194, 45);
            this.labelX5.TabIndex = 44;
            this.labelX5.Text = "Tự động kiểm tra";
            // 
            // lbCountNotConnect
            // 
            // 
            // 
            // 
            this.lbCountNotConnect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCountNotConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountNotConnect.ForeColor = System.Drawing.Color.Red;
            this.lbCountNotConnect.Location = new System.Drawing.Point(231, 216);
            this.lbCountNotConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbCountNotConnect.Name = "lbCountNotConnect";
            this.lbCountNotConnect.Size = new System.Drawing.Size(50, 29);
            this.lbCountNotConnect.TabIndex = 6;
            this.lbCountNotConnect.Text = "0";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.BackColor = System.Drawing.Color.Lime;
            this.metroToggle1.Location = new System.Drawing.Point(231, 306);
            this.metroToggle1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 30);
            this.metroToggle1.TabIndex = 41;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // lbTimer
            // 
            // 
            // 
            // 
            this.lbTimer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Peru;
            this.lbTimer.Location = new System.Drawing.Point(231, 421);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(120, 29);
            this.lbTimer.TabIndex = 11;
            this.lbTimer.Text = "0";
            this.lbTimer.Visible = false;
            this.lbTimer.Click += new System.EventHandler(this.lbTimer_Click);
            // 
            // txtTimeSpan
            // 
            this.txtTimeSpan.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeSpan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeSpan.ForeColor = System.Drawing.Color.Black;
            this.txtTimeSpan.Location = new System.Drawing.Point(231, 361);
            this.txtTimeSpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeSpan.MaxLength = 5;
            this.txtTimeSpan.Name = "txtTimeSpan";
            this.txtTimeSpan.Size = new System.Drawing.Size(65, 28);
            this.txtTimeSpan.TabIndex = 37;
            this.txtTimeSpan.Text = "1";
            this.txtTimeSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeSpan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeSpan_KeyPress);
            // 
            // lbTextKiemTraSau
            // 
            // 
            // 
            // 
            this.lbTextKiemTraSau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTextKiemTraSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextKiemTraSau.Location = new System.Drawing.Point(21, 421);
            this.lbTextKiemTraSau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTextKiemTraSau.Name = "lbTextKiemTraSau";
            this.lbTextKiemTraSau.Size = new System.Drawing.Size(143, 29);
            this.lbTextKiemTraSau.TabIndex = 10;
            this.lbTextKiemTraSau.Text = "Kiểm tra sau";
            this.lbTextKiemTraSau.Visible = false;
            this.lbTextKiemTraSau.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelX9.Location = new System.Drawing.Point(21, 35);
            this.labelX9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(179, 44);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "Trạng thái";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeSyncAuto
            // 
            this.timeSyncAuto.Interval = 1000;
            this.timeSyncAuto.Tick += new System.EventHandler(this.timeSyncAuto_Tick);
            // 
            // NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 885);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1684, 930);
            this.Name = "NhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shyang Hung Cheng - System Sync Data - Copyright @2019 IOTSOFTWARE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhanSu_FormClosing);
            this.panMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tabIcon.ResumeLayout(false);
            this.flowLayout.ResumeLayout(false);
            this.flowLayout.PerformLayout();
            this.tabGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX lbTimer;
        private DevComponents.DotNetBar.LabelX lbTextKiemTraSau;
        private System.Windows.Forms.Button btnSync;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lbCountNotConnect;
        private DevComponents.DotNetBar.LabelX lbCountConnected;
        private DevComponents.DotNetBar.LabelX lbCountMachine;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabIcon;
        private System.Windows.Forms.TabPage tabGrid;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChuaDongBo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Timer timeSyncAuto;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.TextBox txtTimeSpan;
        private DevComponents.DotNetBar.LabelX lbTextWaitting;
    }
}