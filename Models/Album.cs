namespace Models
{
    public class Album
    {
        public string Id;
        public string artist;
        public string title;
        public decimal price;

        public override string ToString()
        {
            return $"{Id} Artist {artist} sa pesmom {title} je zaradio {price}";
        }
    }
}