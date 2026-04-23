using System.Data.SqlClient;
namespace hastaTakipSistemi
{
    internal class frmSqlBaglanti
    {
        string adres = @"Data Source=ALEY\SQLEXPRESS;Initial Catalog=db_HastaneYonetim;Integrated Security=True;Encrypt=False;";
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(adres);
            baglanti.Open();
            return baglanti;
        }

    }
}
/*
 * string adres = @"Data Source=ALEY\SQLEXPRESS;Initial Catalog=db_HastaneYonetim;Integrated Security=True;Encrypt=False;";

 ➡ adres isimli bir connection string tanımlanıyor.
Bu bağlantı cümlesi SQL Server’a nasıl bağlanacağını anlatıyor:

Data Source=ALEY\SQLEXPRESS; → Veritabanının bulunduğu sunucu. (Bilgisayarında ALEY isimli bilgisayar ve SQLEXPRESS SQL Server instance)

Initial Catalog=db_HastaneYonetim; → Bağlanmak istediğin veritabanı (db_HastaneYonetim).

Integrated Security=True; → Windows kimlik doğrulaması ile giriş yapılacak.

Encrypt=False; → Bağlantı sırasında şifreleme kullanılmayacak.
 
 
 */