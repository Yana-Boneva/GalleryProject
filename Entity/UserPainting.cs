namespace GalleryProject.Entity
{
    public class UserPainting
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PaintingID { get; set; }
        public int GalleryID { get; set; }
        public bool IsFavorite { get; set; }
    }
}
