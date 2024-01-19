using DataLayer;
using Models;

namespace BusinessLayer
{
    public class AlbumBusiness
    {
        private AlbumRepository albumRepository=new AlbumRepository();

        public void UnesiAlbum(Album noviAlbum)
        {
            albumRepository.InsertAlbum(noviAlbum);
        }
        public List<Album> VratiSveAlbume()
        {
            List<Album> albumi = new List<Album>();
            albumi = albumRepository.GetAlbums();
            return albumi;
        }
    }
}