using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
            this.Hide();
        }

        private void btnThuCung_Click(object sender, EventArgs e)
        {
            ThuCung tc = new ThuCung();
            tc.Show();
            this.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Show();
            this.Hide();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
