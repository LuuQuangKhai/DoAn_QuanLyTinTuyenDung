namespace DoAn_QuanLyTuyenDung.GUI
{
    partial class TrangChu_GUI
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
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuTrangTuyenDung = new System.Windows.Forms.MenuItem();
            this.menuKetQuaTuyenDung = new System.Windows.Forms.MenuItem();
            this.menuCauHoiThuongGap = new System.Windows.Forms.MenuItem();
            this.menuDangNhap = new System.Windows.Forms.MenuItem();
            this.panelTrangChu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuTrangTuyenDung,
            this.menuKetQuaTuyenDung,
            this.menuCauHoiThuongGap,
            this.menuDangNhap});
            // 
            // menuTrangTuyenDung
            // 
            this.menuTrangTuyenDung.Index = 0;
            this.menuTrangTuyenDung.Text = "Trang tuyển dụng";
            this.menuTrangTuyenDung.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuKetQuaTuyenDung
            // 
            this.menuKetQuaTuyenDung.Index = 1;
            this.menuKetQuaTuyenDung.Text = "Kết quả tuyển dụng";
            this.menuKetQuaTuyenDung.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuCauHoiThuongGap
            // 
            this.menuCauHoiThuongGap.Index = 2;
            this.menuCauHoiThuongGap.Text = "Câu hỏi thường gặp";
            this.menuCauHoiThuongGap.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.Index = 3;
            this.menuDangNhap.Text = "Đăng nhập";
            this.menuDangNhap.Click += new System.EventHandler(this.menuDangNhap_Click);
            // 
            // panelTrangChu
            // 
            this.panelTrangChu.Location = new System.Drawing.Point(12, 12);
            this.panelTrangChu.Name = "panelTrangChu";
            this.panelTrangChu.Size = new System.Drawing.Size(1251, 776);
            this.panelTrangChu.TabIndex = 0;
            // 
            // TrangChu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 800);
            this.Controls.Add(this.panelTrangChu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Menu = this.mainMenu;
            this.Name = "TrangChu_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu_GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuTrangTuyenDung;
        private System.Windows.Forms.MenuItem menuKetQuaTuyenDung;
        private System.Windows.Forms.MenuItem menuCauHoiThuongGap;
        private System.Windows.Forms.MenuItem menuDangNhap;
        private System.Windows.Forms.Panel panelTrangChu;
    }
}