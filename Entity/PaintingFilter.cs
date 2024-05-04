namespace GalleryProject.Entity
{
    public class PaintingFilter
    {
        public int? ID { get; set; }
        public string PaintingName { get; set; } = string.Empty;
        public string PainterName { get; set; } = string.Empty;
        public int? UserID { get; set; }
        public int? StyleID { get; set; }
        public bool IncludeAllData { get; set; }
    }
}
