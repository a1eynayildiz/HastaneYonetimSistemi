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
    }
}
