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
    public partial class ThuCung : Form
    {
        public ThuCung()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void dataTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void LoadThuCung()
        {
            string connStr = "Data Source=.;Initial Catalog=petshop;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT * FROM ThuCung";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataTC.DataSource = dt;
        }

        private void ThuCung_Load(object sender, EventArgs e)
        {
            LoadThuCung();
            dataTC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
