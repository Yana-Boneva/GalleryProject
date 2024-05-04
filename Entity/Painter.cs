namespace GalleryProject.Entity
{
    public class Painter
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string Notes { get; set; } = string.Empty;
        public byte[]? Picture { get; set; }
        public List<string> StylesName { get; set; } = new List<string> { };
    }
}
