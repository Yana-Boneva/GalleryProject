namespace GalleryProject.Entity
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string CreateDate { get; set; } = string.Empty;
        public bool IsAdmin { get; set; }
        public byte[]? Picture { get; set; }

        public override string? ToString()
        {
            return Username;
        }

    }
}
