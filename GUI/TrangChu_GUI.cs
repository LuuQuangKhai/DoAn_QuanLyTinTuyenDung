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
    public partial class TrangChu_GUI : Form
    {
        public TrangChu_GUI()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            panelTrangChu.Controls.Clear();
            KetQuaTuyenDung_GUI gui = new KetQuaTuyenDung_GUI();
            //gui.Visible = true;
            panelTrangChu.Controls.Add(gui);
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            panelTrangChu.Controls.Clear();
            TrangTuyenDung_GUI gui = new TrangTuyenDung_GUI();
            panelTrangChu.Controls.Add(gui);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            panelTrangChu.Controls.Clear();

        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap_GUI gui = new DangNhap_GUI();
            gui.FormClosed += gui_FormClosed;
            gui.Show();
        }

        void gui_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
