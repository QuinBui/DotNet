
namespace cafe
{
    partial class ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_tien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_khach = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_thoi = new Bunifu.UI.WinForms.BunifuTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Dongia});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(443, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(780, 367);
            this.dataGridView1.TabIndex = 13;
            this.ToolTip1.SetToolTip(this.dataGridView1, "");
            this.ToolTip1.SetToolTipIcon(this.dataGridView1, null);
            this.ToolTip1.SetToolTipTitle(this.dataGridView1, "");
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "DoUong";
            this.Ten.HeaderText = "Tên Đồ Uống";
            this.Ten.MinimumWidth = 10;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "DonGia";
            this.Dongia.HeaderText = "Đơn Giá";
            this.Dongia.MinimumWidth = 10;
            this.Dongia.Name = "Dongia";
            this.Dongia.ReadOnly = true;
            this.Dongia.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(959, 427);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "VNĐ";
            this.ToolTip1.SetToolTip(this.label7, "");
            this.ToolTip1.SetToolTipIcon(this.label7, null);
            this.ToolTip1.SetToolTipTitle(this.label7, "");
            // 
            // lb_tien
            // 
            this.lb_tien.AutoSize = true;
            this.lb_tien.BackColor = System.Drawing.Color.Transparent;
            this.lb_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tien.ForeColor = System.Drawing.Color.Red;
            this.lb_tien.Location = new System.Drawing.Point(738, 427);
            this.lb_tien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tien.Name = "lb_tien";
            this.lb_tien.Size = new System.Drawing.Size(30, 31);
            this.lb_tien.TabIndex = 10;
            this.lb_tien.Text = "0";
            this.ToolTip1.SetToolTip(this.lb_tien, "");
            this.ToolTip1.SetToolTipIcon(this.lb_tien, null);
            this.ToolTip1.SetToolTipTitle(this.lb_tien, "");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(523, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng Tiền ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.label5, "");
            this.ToolTip1.SetToolTipIcon(this.label5, null);
            this.ToolTip1.SetToolTipTitle(this.label5, "");
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_thoat.BackgroundImage")));
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_thoat.Location = new System.Drawing.Point(959, 639);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(109, 90);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip1.SetToolTip(this.btn_thoat, "");
            this.ToolTip1.SetToolTipIcon(this.btn_thoat, null);
            this.ToolTip1.SetToolTipTitle(this.btn_thoat, "");
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_thanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_thanhToan.BackgroundImage")));
            this.btn_thanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_thanhToan.ForeColor = System.Drawing.Color.Maroon;
            this.btn_thanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thanhToan.Location = new System.Drawing.Point(523, 639);
            this.btn_thanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(130, 90);
            this.btn_thanhToan.TabIndex = 7;
            this.ToolTip1.SetToolTip(this.btn_thanhToan, "");
            this.ToolTip1.SetToolTipIcon(this.btn_thanhToan, null);
            this.ToolTip1.SetToolTipTitle(this.btn_thanhToan, "");
            this.btn_thanhToan.UseVisualStyleBackColor = false;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(523, 502);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Số tiền khách đưa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.label1, "");
            this.ToolTip1.SetToolTipIcon(this.label1, null);
            this.ToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(523, 569);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số tiền phải thối lại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.label2, "");
            this.ToolTip1.SetToolTipIcon(this.label2, null);
            this.ToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.12018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.77588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.601467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.60391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.09291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.08639F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_thoat, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_thanhToan, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_tien, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_khach, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_thoi, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.15962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.094134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.23192F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.140518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.004093F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23329F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 733);
            this.tableLayoutPanel1.TabIndex = 18;
            this.ToolTip1.SetToolTip(this.tableLayoutPanel1, "");
            this.ToolTip1.SetToolTipIcon(this.tableLayoutPanel1, null);
            this.ToolTip1.SetToolTipTitle(this.tableLayoutPanel1, "");
            // 
            // txt_khach
            // 
            this.txt_khach.AcceptsReturn = false;
            this.txt_khach.AcceptsTab = false;
            this.txt_khach.AnimationSpeed = 200;
            this.txt_khach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_khach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_khach.BackColor = System.Drawing.Color.Transparent;
            this.txt_khach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_khach.BackgroundImage")));
            this.txt_khach.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_khach.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_khach.BorderColorHover = System.Drawing.Color.LightCoral;
            this.txt_khach.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_khach.BorderRadius = 1;
            this.txt_khach.BorderThickness = 1;
            this.txt_khach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_khach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_khach.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_khach.DefaultText = "";
            this.txt_khach.FillColor = System.Drawing.Color.White;
            this.txt_khach.HideSelection = true;
            this.txt_khach.IconLeft = null;
            this.txt_khach.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_khach.IconPadding = 10;
            this.txt_khach.IconRight = null;
            this.txt_khach.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_khach.Lines = new string[0];
            this.txt_khach.Location = new System.Drawing.Point(737, 505);
            this.txt_khach.MaxLength = 32767;
            this.txt_khach.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_khach.Modified = false;
            this.txt_khach.Multiline = false;
            this.txt_khach.Name = "txt_khach";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_khach.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_khach.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.LightCoral;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_khach.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_khach.OnIdleState = stateProperties4;
            this.txt_khach.Padding = new System.Windows.Forms.Padding(3);
            this.txt_khach.PasswordChar = '\0';
            this.txt_khach.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_khach.PlaceholderText = "Tiền nhận";
            this.txt_khach.ReadOnly = false;
            this.txt_khach.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_khach.SelectedText = "";
            this.txt_khach.SelectionLength = 0;
            this.txt_khach.SelectionStart = 0;
            this.txt_khach.ShortcutsEnabled = true;
            this.txt_khach.Size = new System.Drawing.Size(215, 53);
            this.txt_khach.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_khach.TabIndex = 18;
            this.txt_khach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_khach.TextMarginBottom = 0;
            this.txt_khach.TextMarginLeft = 3;
            this.txt_khach.TextMarginTop = 0;
            this.txt_khach.TextPlaceholder = "Tiền nhận";
            this.ToolTip1.SetToolTip(this.txt_khach, "");
            this.ToolTip1.SetToolTipIcon(this.txt_khach, null);
            this.ToolTip1.SetToolTipTitle(this.txt_khach, "");
            this.txt_khach.UseSystemPasswordChar = false;
            this.txt_khach.WordWrap = true;
            // 
            // txt_thoi
            // 
            this.txt_thoi.AcceptsReturn = false;
            this.txt_thoi.AcceptsTab = false;
            this.txt_thoi.AnimationSpeed = 200;
            this.txt_thoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_thoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_thoi.BackColor = System.Drawing.Color.Transparent;
            this.txt_thoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_thoi.BackgroundImage")));
            this.txt_thoi.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_thoi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_thoi.BorderColorHover = System.Drawing.Color.LightCoral;
            this.txt_thoi.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_thoi.BorderRadius = 1;
            this.txt_thoi.BorderThickness = 1;
            this.txt_thoi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_thoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thoi.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_thoi.DefaultText = "";
            this.txt_thoi.FillColor = System.Drawing.Color.White;
            this.txt_thoi.HideSelection = true;
            this.txt_thoi.IconLeft = null;
            this.txt_thoi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thoi.IconPadding = 10;
            this.txt_thoi.IconRight = null;
            this.txt_thoi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thoi.Lines = new string[0];
            this.txt_thoi.Location = new System.Drawing.Point(737, 572);
            this.txt_thoi.MaxLength = 32767;
            this.txt_thoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_thoi.Modified = false;
            this.txt_thoi.Multiline = false;
            this.txt_thoi.Name = "txt_thoi";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_thoi.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_thoi.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.LightCoral;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_thoi.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_thoi.OnIdleState = stateProperties8;
            this.txt_thoi.Padding = new System.Windows.Forms.Padding(3);
            this.txt_thoi.PasswordChar = '\0';
            this.txt_thoi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_thoi.PlaceholderText = "Tiền thối";
            this.txt_thoi.ReadOnly = false;
            this.txt_thoi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_thoi.SelectedText = "";
            this.txt_thoi.SelectionLength = 0;
            this.txt_thoi.SelectionStart = 0;
            this.txt_thoi.ShortcutsEnabled = true;
            this.txt_thoi.Size = new System.Drawing.Size(215, 53);
            this.txt_thoi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_thoi.TabIndex = 19;
            this.txt_thoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_thoi.TextMarginBottom = 0;
            this.txt_thoi.TextMarginLeft = 3;
            this.txt_thoi.TextMarginTop = 0;
            this.txt_thoi.TextPlaceholder = "Tiền thối";
            this.ToolTip1.SetToolTip(this.txt_thoi, "");
            this.ToolTip1.SetToolTipIcon(this.txt_thoi, null);
            this.ToolTip1.SetToolTipTitle(this.txt_thoi, "");
            this.txt_thoi.UseSystemPasswordChar = false;
            this.txt_thoi.WordWrap = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(737, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 92);
            this.button1.TabIndex = 20;
            this.ToolTip1.SetToolTip(this.button1, "");
            this.ToolTip1.SetToolTipIcon(this.button1, null);
            this.ToolTip1.SetToolTipTitle(this.button1, "");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.Active = true;
            this.ToolTip1.AlignTextWithTitle = false;
            this.ToolTip1.AllowAutoClose = false;
            this.ToolTip1.AllowFading = true;
            this.ToolTip1.AutoCloseDuration = 5000;
            this.ToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.ToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.ToolTip1.ClickToShowDisplayControl = false;
            this.ToolTip1.ConvertNewlinesToBreakTags = true;
            this.ToolTip1.DisplayControl = null;
            this.ToolTip1.EntryAnimationSpeed = 350;
            this.ToolTip1.ExitAnimationSpeed = 200;
            this.ToolTip1.GenerateAutoCloseDuration = false;
            this.ToolTip1.IconMargin = 6;
            this.ToolTip1.InitialDelay = 0;
            this.ToolTip1.Name = "ToolTip1";
            this.ToolTip1.Opacity = 1D;
            this.ToolTip1.OverrideToolTipTitles = false;
            this.ToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.ToolTip1.ReshowDelay = 100;
            this.ToolTip1.ShowAlways = true;
            this.ToolTip1.ShowBorders = false;
            this.ToolTip1.ShowIcons = true;
            this.ToolTip1.ShowShadows = true;
            this.ToolTip1.Tag = null;
            this.ToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolTip1.TextMargin = 2;
            this.ToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.ToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.ToolTip1.ToolTipTitle = null;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1227, 733);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThanhToan";
            this.Text = "THANH TOÁN";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_tien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_khach;
        private Bunifu.UI.WinForms.BunifuTextBox txt_thoi;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuToolTip ToolTip1;
    }
}