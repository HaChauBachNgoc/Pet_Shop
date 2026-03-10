using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        void LoadKhachHang()
        {
            string connStr = "Data Source=.;Initial Catalog=petshop;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT * FROM KhachHang";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataKH.DataSource = dt;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            dataKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
    }
}
