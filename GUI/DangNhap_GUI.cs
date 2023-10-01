using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QuanLyTuyenDung.GUI;

namespace DoAn_QuanLyTuyenDung.GUI
{
    public partial class DangNhap_GUI : Form
    {
        public DangNhap_GUI()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            GiaoDienQuanLy_GUI gui = new GiaoDienQuanLy_GUI();
            this.Hide();
            gui.FormClosed += gui_FormClosed;
            gui.Show();
        }

        void gui_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
