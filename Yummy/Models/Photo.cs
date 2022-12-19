namespace Yummy.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string ImageName { get; set; } = "";
        public int PhotoAlbumId { get; set; }
        public PhotoAlbum photoAlbum { get; set; }
    }
}
