using BusinessLayer;
using Models;

namespace Aplikaccija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string artist = txtTitle.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);

            Album noviAlbum = new Album()
            {
                title = title,
                artist = artist,
                price = price,
            };
            List<Album> albums = new List<Album>();
            AlbumBusiness albumBusiness = new AlbumBusiness();
            albumBusiness.UnesiAlbum(noviAlbum);
            OcistiTextBoxove();
            UnesiUListBox();
        }
        public void OcistiTextBoxove()
        {
            txtArtist.Clear();
            txtPrice.Clear();
            txtTitle.Clear();
        }
        public void UnesiUListBox()
        {
            listBox1.Items.Clear();
            List<Album> albumi = new List<Album>();
            AlbumBusiness albumBusiness = new AlbumBusiness();
            albumi = albumBusiness.VratiSveAlbume();
            foreach(Album album in albumi) 
            { 
               listBox1.Items.Add(album);
            }
        }
    }
}