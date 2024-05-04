namespace GalleryProject.Entity
{
    public class Painting
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public int? PainterID { get; set; }
        public int? StyleID { get; set; }
        public byte[]? Picture { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
