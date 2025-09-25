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

namespace hastaTakipSistemi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
            durumDoldur();
        }

        private void Listele()
        {
            SqlCommand liste = new SqlCommand("listele", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(liste);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void durumDoldur()
        {
            SqlCommand durum = new SqlCommand("durumDoldur",bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtDurum.DataSource = dt;
            txtDurum.DisplayMember = "durumAd";
            txtDurum.ValueMember = "durumID";

            

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
