using Models;
using System.Data.SqlClient;

namespace DataLayer
{
    public class AlbumRepository
    {
        private string vezaSaBazom = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\Aplikaccija\\DataLayer\\MusicDB.mdf;Integrated Security=True";
        
        public void InsertAlbum(Album noviAlbum)
        {
            using(SqlConnection conn = new SqlConnection(vezaSaBazom))
            {
                conn.Open();
                string upit = "Insert into Albums(title,artist,price) values(@title,@artist,@price)";
                using(SqlCommand komanda = new SqlCommand(upit,conn)) {

                    komanda.Parameters.AddWithValue("@title",noviAlbum.title);
                    komanda.Parameters.AddWithValue("@artist",noviAlbum.artist);
                    komanda.Parameters.AddWithValue("@price",noviAlbum.price);

                    komanda.ExecuteNonQuery();
                }
            }
        }

        public List<Album> GetAlbums()
        {
            List<Album> albums = new List<Album>();

            using(SqlConnection conn = new SqlConnection(vezaSaBazom))
            {
                conn.Open();
                string upit = "select * from Albums";
                using(SqlCommand komanda = new SqlCommand(upit,conn)) {
                    using(SqlDataReader citac = komanda.ExecuteReader())
                    {
                        while (citac.Read())
                        {
                            Album noviAlbum = new Album()
                            {
                                title = (string)citac["title"],
                                artist = (string)citac["artist"],
                                price = (decimal)citac["price"],

                            };
                            albums.Add(noviAlbum);
                        }
                    }
                }
            }
            return albums;
        }
    }
}