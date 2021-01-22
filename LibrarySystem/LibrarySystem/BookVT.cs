using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace LibrarySystem
{

    
    class BookVT
    {

        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\merve\OneDrive\Belgeler\Library.accdb");

        public List<Book> List()
        {
            List<Book> ktp = new List<Book>();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Books", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Book b = new Book();
                b.ID= Convert.ToInt32(dr[0].ToString());
                b.NAME= dr[1].ToString();
                b.AUTHOR = dr[2].ToString();
                b.LINK = dr[3].ToString();

                ktp.Add(b);

            }
            baglanti.Close();
            return ktp;
        }

        public void KitapEkle(Book kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Books (book_name,book_author,link) values (@p1, @p2, @p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.NAME);
            komut.Parameters.AddWithValue("@p2", kt.AUTHOR);
            komut.Parameters.AddWithValue("@p3", kt.LINK);
            komut.ExecuteNonQuery();
            baglanti.Close();
            

        }

        public void KitapSil(Book dl)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Books where book_name = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", dl.NAME);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
