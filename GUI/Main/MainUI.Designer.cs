﻿namespace ChinChin.UI
{
    partial class MainUI
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
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlBorderOfForm = new System.Windows.Forms.Panel();
            this.pnlLeftSidebar = new System.Windows.Forms.Panel();
            this.ibtnBaoCao = new FontAwesome.Sharp.IconButton();
            this.ibtnNhanSu = new FontAwesome.Sharp.IconButton();
            this.ibtnThucDon = new FontAwesome.Sharp.IconButton();
            this.ibtnVatTu = new FontAwesome.Sharp.IconButton();
            this.ibtnNhanDon = new FontAwesome.Sharp.IconButton();
            this.ibtnThongKe = new FontAwesome.Sharp.IconButton();
            this.pnlQuan = new System.Windows.Forms.Panel();
            this.ipbThemQuan = new FontAwesome.Sharp.IconPictureBox();
            this.cbbChuyenQuan = new System.Windows.Forms.ComboBox();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.pnlTaiKhoanVaButtons = new System.Windows.Forms.Panel();
            this.mnsTaiKhoan = new System.Windows.Forms.MenuStrip();
            this.mnsiIconTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiCaiDat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.labelTittleChildForm = new System.Windows.Forms.Label();
            this.pnlBorderOfForm.SuspendLayout();
            this.pnlLeftSidebar.SuspendLayout();
            this.pnlQuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbThemQuan)).BeginInit();
            this.panelTittleBar.SuspendLayout();
            this.pnlTaiKhoanVaButtons.SuspendLayout();
            this.mnsTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.White;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(376, 70);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(607, 730);
            this.pnlChildForm.TabIndex = 14;
            // 
            // pnlBorderOfForm
            // 
            this.pnlBorderOfForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorderOfForm.Controls.Add(this.pnlChildForm);
            this.pnlBorderOfForm.Controls.Add(this.pnlLeftSidebar);
            this.pnlBorderOfForm.Controls.Add(this.panelTittleBar);
            this.pnlBorderOfForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorderOfForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBorderOfForm.Location = new System.Drawing.Point(0, 0);
            this.pnlBorderOfForm.Name = "pnlBorderOfForm";
            this.pnlBorderOfForm.Size = new System.Drawing.Size(985, 802);
            this.pnlBorderOfForm.TabIndex = 0;
            // 
            // pnlLeftSidebar
            // 
            this.pnlLeftSidebar.BackColor = System.Drawing.Color.White;
            this.pnlLeftSidebar.Controls.Add(this.ibtnBaoCao);
            this.pnlLeftSidebar.Controls.Add(this.ibtnNhanSu);
            this.pnlLeftSidebar.Controls.Add(this.ibtnThucDon);
            this.pnlLeftSidebar.Controls.Add(this.ibtnVatTu);
            this.pnlLeftSidebar.Controls.Add(this.ibtnNhanDon);
            this.pnlLeftSidebar.Controls.Add(this.ibtnThongKe);
            this.pnlLeftSidebar.Controls.Add(this.pnlQuan);
            this.pnlLeftSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSidebar.ForeColor = System.Drawing.Color.Coral;
            this.pnlLeftSidebar.Location = new System.Drawing.Point(0, 70);
            this.pnlLeftSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeftSidebar.Name = "pnlLeftSidebar";
            this.pnlLeftSidebar.Size = new System.Drawing.Size(376, 730);
            this.pnlLeftSidebar.TabIndex = 17;
            // 
            // ibtnBaoCao
            // 
            this.ibtnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnBaoCao.FlatAppearance.BorderSize = 0;
            this.ibtnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBaoCao.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnBaoCao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnBaoCao.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ibtnBaoCao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtnBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnBaoCao.Location = new System.Drawing.Point(0, 571);
            this.ibtnBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnBaoCao.Name = "ibtnBaoCao";
            this.ibtnBaoCao.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtnBaoCao.Size = new System.Drawing.Size(376, 102);
            this.ibtnBaoCao.TabIndex = 14;
            this.ibtnBaoCao.Text = "BÁO CÁO";
            this.ibtnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnBaoCao.UseVisualStyleBackColor = true;
            this.ibtnBaoCao.Click += new System.EventHandler(this.ibtnBaoCao_Click);
            // 
            // ibtnNhanSu
            // 
            this.ibtnNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnNhanSu.FlatAppearance.BorderSize = 0;
            this.ibtnNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNhanSu.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnNhanSu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnNhanSu.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ibtnNhanSu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtnNhanSu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNhanSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNhanSu.Location = new System.Drawing.Point(0, 469);
            this.ibtnNhanSu.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnNhanSu.Name = "ibtnNhanSu";
            this.ibtnNhanSu.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtnNhanSu.Size = new System.Drawing.Size(376, 102);
            this.ibtnNhanSu.TabIndex = 13;
            this.ibtnNhanSu.Text = "NHÂN SỰ";
            this.ibtnNhanSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnNhanSu.UseVisualStyleBackColor = true;
            this.ibtnNhanSu.Click += new System.EventHandler(this.ibtnNhanSu_Click);
            // 
            // ibtnThucDon
            // 
            this.ibtnThucDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnThucDon.FlatAppearance.BorderSize = 0;
            this.ibtnThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThucDon.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnThucDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnThucDon.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ibtnThucDon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtnThucDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThucDon.Location = new System.Drawing.Point(0, 367);
            this.ibtnThucDon.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnThucDon.Name = "ibtnThucDon";
            this.ibtnThucDon.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtnThucDon.Size = new System.Drawing.Size(376, 102);
            this.ibtnThucDon.TabIndex = 11;
            this.ibtnThucDon.Text = "THỰC ĐƠN";
            this.ibtnThucDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThucDon.UseVisualStyleBackColor = true;
            this.ibtnThucDon.Click += new System.EventHandler(this.ibtnThucDon_Click);
            // 
            // ibtnVatTu
            // 
            this.ibtnVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnVatTu.FlatAppearance.BorderSize = 0;
            this.ibtnVatTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnVatTu.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnVatTu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnVatTu.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ibtnVatTu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtnVatTu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnVatTu.Location = new System.Drawing.Point(0, 265);
            this.ibtnVatTu.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnVatTu.Name = "ibtnVatTu";
            this.ibtnVatTu.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtnVatTu.Size = new System.Drawing.Size(376, 102);
            this.ibtnVatTu.TabIndex = 10;
            this.ibtnVatTu.Text = "VẬT TƯ";
            this.ibtnVatTu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnVatTu.UseVisualStyleBackColor = true;
            this.ibtnVatTu.Click += new System.EventHandler(this.ibtnVatTu_Click);
            // 
            // ibtnNhanDon
            // 
            this.ibtnNhanDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnNhanDon.FlatAppearance.BorderSize = 0;
            this.ibtnNhanDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNhanDon.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnNhanDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnNhanDon.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.ibtnNhanDon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtnNhanDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNhanDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnNhanDon.Location = new System.Drawing.Point(0, 163);
            this.ibtnNhanDon.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnNhanDon.Name = "ibtnNhanDon";
            this.ibtnNhanDon.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtnNhanDon.Size = new System.Drawing.Size(376, 102);
            this.ibtnNhanDon.TabIndex = 9;
            this.ibtnNhanDon.Text = "NHẬN ĐƠN";
            this.ibtnNhanDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnNhanDon.UseVisualStyleBackColor = true;
            this.ibtnNhanDon.Click += new System.EventHandler(this.ibtnNhanDon_Click);
            // 
            // ibtnThongKe
            // 
            this.ibtnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnThongKe.FlatAppearance.BorderSize = 0;
            this.ibtnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThongKe.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnThongKe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnThongKe.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.ibtnThongKe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ibtnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThongKe.Location = new System.Drawing.Point(0, 63);
            this.ibtnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnThongKe.Name = "ibtnThongKe";
            this.ibtnThongKe.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.ibtnThongKe.Size = new System.Drawing.Size(376, 100);
            this.ibtnThongKe.TabIndex = 7;
            this.ibtnThongKe.Text = "THỐNG KÊ";
            this.ibtnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThongKe.UseVisualStyleBackColor = true;
            this.ibtnThongKe.Click += new System.EventHandler(this.ibtnThongKe_Click);
            // 
            // pnlQuan
            // 
            this.pnlQuan.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuan.Controls.Add(this.ipbThemQuan);
            this.pnlQuan.Controls.Add(this.cbbChuyenQuan);
            this.pnlQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuan.Location = new System.Drawing.Point(0, 0);
            this.pnlQuan.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuan.Name = "pnlQuan";
            this.pnlQuan.Size = new System.Drawing.Size(376, 63);
            this.pnlQuan.TabIndex = 0;
            // 
            // ipbThemQuan
            // 
            this.ipbThemQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbThemQuan.BackColor = System.Drawing.Color.White;
            this.ipbThemQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ipbThemQuan.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ipbThemQuan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.ipbThemQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbThemQuan.IconSize = 50;
            this.ipbThemQuan.Location = new System.Drawing.Point(233, 11);
            this.ipbThemQuan.Margin = new System.Windows.Forms.Padding(2);
            this.ipbThemQuan.Name = "ipbThemQuan";
            this.ipbThemQuan.Size = new System.Drawing.Size(50, 50);
            this.ipbThemQuan.TabIndex = 3;
            this.ipbThemQuan.TabStop = false;
            // 
            // cbbChuyenQuan
            // 
            this.cbbChuyenQuan.BackColor = System.Drawing.Color.White;
            this.cbbChuyenQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbChuyenQuan.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChuyenQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbbChuyenQuan.FormattingEnabled = true;
            this.cbbChuyenQuan.Location = new System.Drawing.Point(11, 14);
            this.cbbChuyenQuan.Name = "cbbChuyenQuan";
            this.cbbChuyenQuan.Size = new System.Drawing.Size(217, 36);
            this.cbbChuyenQuan.TabIndex = 1;
            this.cbbChuyenQuan.Text = "Chuyển quán";
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.White;
            this.panelTittleBar.Controls.Add(this.pnlTaiKhoanVaButtons);
            this.panelTittleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTittleBar.Controls.Add(this.labelTittleChildForm);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTittleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(983, 70);
            this.panelTittleBar.TabIndex = 16;
            this.panelTittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTittleBar_MouseDown);
            // 
            // pnlTaiKhoanVaButtons
            // 
            this.pnlTaiKhoanVaButtons.Controls.Add(this.mnsTaiKhoan);
            this.pnlTaiKhoanVaButtons.Controls.Add(this.btnExit);
            this.pnlTaiKhoanVaButtons.Controls.Add(this.btnMaximize);
            this.pnlTaiKhoanVaButtons.Controls.Add(this.btnMinimize);
            this.pnlTaiKhoanVaButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTaiKhoanVaButtons.Location = new System.Drawing.Point(737, 0);
            this.pnlTaiKhoanVaButtons.Name = "pnlTaiKhoanVaButtons";
            this.pnlTaiKhoanVaButtons.Size = new System.Drawing.Size(246, 70);
            this.pnlTaiKhoanVaButtons.TabIndex = 17;
            // 
            // mnsTaiKhoan
            // 
            this.mnsTaiKhoan.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiIconTaiKhoan});
            this.mnsTaiKhoan.Location = new System.Drawing.Point(0, 1);
            this.mnsTaiKhoan.Name = "mnsTaiKhoan";
            this.mnsTaiKhoan.Size = new System.Drawing.Size(77, 70);
            this.mnsTaiKhoan.TabIndex = 16;
            this.mnsTaiKhoan.Text = "msTaiKhoan";
            // 
            // mnsiIconTaiKhoan
            // 
            this.mnsiIconTaiKhoan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnsiIconTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsiThongTinTaiKhoan,
            this.mnsiCaiDat,
            this.mnsiDangXuat});
            this.mnsiIconTaiKhoan.Image = global::ChinChin.Properties.Resources.image;
            this.mnsiIconTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mnsiIconTaiKhoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnsiIconTaiKhoan.Name = "mnsiIconTaiKhoan";
            this.mnsiIconTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnsiIconTaiKhoan.RightToLeftAutoMirrorImage = true;
            this.mnsiIconTaiKhoan.Size = new System.Drawing.Size(69, 66);
            this.mnsiIconTaiKhoan.Text = "Tài khoản";
            this.mnsiIconTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnsiIconTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnsiThongTinTaiKhoan
            // 
            this.mnsiThongTinTaiKhoan.Name = "mnsiThongTinTaiKhoan";
            this.mnsiThongTinTaiKhoan.Size = new System.Drawing.Size(181, 22);
            this.mnsiThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            this.mnsiThongTinTaiKhoan.Click += new System.EventHandler(this.mnsiThongTinTaiKhoan_Click);
            // 
            // mnsiCaiDat
            // 
            this.mnsiCaiDat.Name = "mnsiCaiDat";
            this.mnsiCaiDat.Size = new System.Drawing.Size(181, 22);
            this.mnsiCaiDat.Text = "Cài đặt";
            this.mnsiCaiDat.Click += new System.EventHandler(this.mnsiCaiDat_Click);
            // 
            // mnsiDangXuat
            // 
            this.mnsiDangXuat.Name = "mnsiDangXuat";
            this.mnsiDangXuat.Size = new System.Drawing.Size(181, 22);
            this.mnsiDangXuat.Text = "Đăng Xuất";
            this.mnsiDangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 50;
            this.btnExit.Location = new System.Drawing.Point(194, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 50;
            this.btnMaximize.Location = new System.Drawing.Point(140, 2);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 50);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 50;
            this.btnMinimize.Location = new System.Drawing.Point(86, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 46;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 11);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(46, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // labelTittleChildForm
            // 
            this.labelTittleChildForm.AutoSize = true;
            this.labelTittleChildForm.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleChildForm.Location = new System.Drawing.Point(50, 21);
            this.labelTittleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleChildForm.Name = "labelTittleChildForm";
            this.labelTittleChildForm.Size = new System.Drawing.Size(45, 20);
            this.labelTittleChildForm.TabIndex = 1;
            this.labelTittleChildForm.Text = "Home";
            this.labelTittleChildForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 802);
            this.Controls.Add(this.pnlBorderOfForm);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.pnlBorderOfForm.ResumeLayout(false);
            this.pnlLeftSidebar.ResumeLayout(false);
            this.pnlQuan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbThemQuan)).EndInit();
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            this.pnlTaiKhoanVaButtons.ResumeLayout(false);
            this.pnlTaiKhoanVaButtons.PerformLayout();
            this.mnsTaiKhoan.ResumeLayout(false);
            this.mnsTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel pnlBorderOfForm;
        private System.Windows.Forms.Panel pnlLeftSidebar;
        private FontAwesome.Sharp.IconButton ibtnVatTu;
        private FontAwesome.Sharp.IconButton ibtnNhanDon;
        private FontAwesome.Sharp.IconButton ibtnThongKe;
        private System.Windows.Forms.Panel pnlQuan;
        private System.Windows.Forms.Panel panelTittleBar;
        private System.Windows.Forms.Panel pnlTaiKhoanVaButtons;
        private System.Windows.Forms.MenuStrip mnsTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsiIconTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsiThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsiCaiDat;
        private System.Windows.Forms.ToolStripMenuItem mnsiDangXuat;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTittleChildForm;
        private FontAwesome.Sharp.IconButton ibtnThucDon;
        private FontAwesome.Sharp.IconButton ibtnNhanSu;
        private System.Windows.Forms.ComboBox cbbChuyenQuan;
        private FontAwesome.Sharp.IconPictureBox ipbThemQuan;
        private FontAwesome.Sharp.IconButton ibtnBaoCao;
    }
}