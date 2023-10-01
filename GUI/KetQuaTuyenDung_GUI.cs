using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyTuyenDung.GUI
{
    public partial class KetQuaTuyenDung_GUI : UserControl
    {
        public KetQuaTuyenDung_GUI()
        {
            InitializeComponent();
            this.txtCMND.ForeColor = Color.Gray;
            this.txtSoDienThoai.ForeColor = Color.Gray;
            this.txtCMND.Text = "Nhập CMND hoặc CCCD";
            this.txtSoDienThoai.Text = "Nhập số điện thoại";
            this.lblThongBao.Visible = false;
        }

        private void KetQuaTuyenDung_GUI_Load(object sender, EventArgs e)
        {

        }

        private void txtCMND_Enter(object sender, EventArgs e)
        {
            if(this.txtCMND.Text == "Nhập CMND hoặc CCCD")
            {
                this.txtCMND.Text = "";
                this.txtCMND.ForeColor = Color.Black;
            }
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.txtCMND.Text))
            {
                this.txtCMND.Text = "Nhập CMND hoặc CCCD";
                this.txtCMND.ForeColor = Color.Gray;
            }
        }

        private void txtSoDienThoai_Enter(object sender, EventArgs e)
        {
            if(this.txtSoDienThoai.Text == "Nhập số điện thoại")
            {
                this.txtSoDienThoai.Text = "";
                this.txtSoDienThoai.ForeColor = Color.Black;
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.txtSoDienThoai.Text))
            {
                this.txtSoDienThoai.Text = "Nhập số điện thoại";
                this.txtSoDienThoai.ForeColor = Color.Gray;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtSoDienThoai.Text.Equals("Nhập số điện thoại") || this.txtCMND.Text.Equals("Nhập CMND hoặc CCCD"))
            {
                this.lblThongBao.Text = "*Vui lòng nhập đầy đủ thông tin!";
                this.lblThongBao.Visible = true;
            }
            else
            {
                this.lblThongBao.Text = "*Thông tin không tồn tại!";
                this.lblThongBao.Visible = true;
            }
        }
    }
}
