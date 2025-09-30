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
    public partial class frmIstatistic : Form
    {
        public frmIstatistic()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmIstatistic_Load(object sender, EventArgs e)
        {
            toplamHasta();
            yasOrtalama();
            erkekSayi();
            kadinSayi();
        }
        private void toplamHasta()
        {
            SqlCommand toplam = new SqlCommand("SELECT COUNT(*) FROM tbl_HastaBilgi",bgl.baglan());
            toplam.ExecuteNonQuery();
            SqlDataReader dr = toplam.ExecuteReader();
            while (dr.Read())
            {
                lblToplamHasta.Text = dr[0].ToString();
            }
        }
        private void yasOrtalama()
        {
            SqlCommand ortalama = new SqlCommand("select AVG(hYas) from tbl_HastaBilgi", bgl.baglan());
            ortalama.ExecuteNonQuery();
            SqlDataReader dr = ortalama.ExecuteReader();
            while (dr.Read())
            {
                lblYasOrtalama.Text = dr[0].ToString();
            }
        }
        private void erkekSayi()
        {
            SqlCommand erkekSayi = new SqlCommand("SELECT COUNT(*) FROM tbl_HastaBilgi where hCinsiyet = 'Erkek'", bgl.baglan());
            erkekSayi.ExecuteNonQuery();
            SqlDataReader dr = erkekSayi.ExecuteReader();
            while (dr.Read())
            {
                lblErkekSayi.Text = dr[0].ToString();
            }
        }

        private void kadinSayi()
        {
            SqlCommand kadinSayi = new SqlCommand("SELECT COUNT(*) FROM tbl_HastaBilgi where hCinsiyet = 'Kadın'", bgl.baglan());
            kadinSayi.ExecuteNonQuery();
            SqlDataReader dr = kadinSayi.ExecuteReader();
            while (dr.Read())
            {
                lblKadinSayi.Text = dr[0].ToString();
            }
        }



    }
}
