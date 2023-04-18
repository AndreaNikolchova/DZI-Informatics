namespace _1._3._10
{
    public class Song
    {
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Song()
        {
            this.Name = "unknown";
            this.Artist = "unknown";
        }
        public Song(string name)
        {
            this.Name = name;
            this.Artist = "unknown";
        }
        public Song(string name,string artist)
        {
            this.Name = name;
            this.Artist = artist;
        }
    }
}
