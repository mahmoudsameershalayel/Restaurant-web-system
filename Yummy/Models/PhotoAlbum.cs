namespace Yummy.Models
{
    public class PhotoAlbum
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public List<Photo> photos { get; set; }
    }
}
