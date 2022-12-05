using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStrTest);
            cmd = con.CreateCommand();
        }
        public bool KategoriEkle(Kategori kat)
        {
            try
            {
                cmd.CommandText = "INSERT INTO TblKategoriler(KategoriAdı,Açıklama)VALUES (@k,@a)";
                cmd.Parameters.AddWithValue("@k", kat.Isim);
                cmd.Parameters.AddWithValue("@a", kat.Aciklama);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Kategori> kategorilistele()
        {
            try
            {
                List<Kategori> kategoriler = new List<Kategori>();
                cmd.CommandText = "SELECT kategoryID,KategoriAdı,Açıklama FROM TblKategoriler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategori kat = new Kategori();
                    kat.ID = reader.GetInt32(0);
                    kat.Isim = reader.GetString(1);
                    kat.Aciklama = reader.GetString(2);
                    kategoriler.Add(kat);
                }
                return kategoriler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            
        }
        public Kategori GetCategory(int id)
        {
            try
            {
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Kategori c = new Kategori();
                while (reader.Read())
                {
                    c.ID = reader.GetInt32(0);
                    c.Isim = reader.GetString(1);
                    c.Aciklama = reader.GetString(2);
                }
                return c;

            }
            catch (Exception)
            {
                return null;
                
            }
            finally { con.Close(); }
        }
       
       

        

    }
}
