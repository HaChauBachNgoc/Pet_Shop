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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            dataSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void LoadSanPham()
        {
            string connStr = "Data Source=.;Initial Catalog=petshop;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT * FROM SanPham";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataSP.DataSource = dt;
        }
    }
}
