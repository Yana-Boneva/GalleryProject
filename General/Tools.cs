using System.Security.Cryptography;
using System.Text;

namespace GalleryProject.General
{
    public static class Tools
    {
        public static string HashPassword(string text)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            byte[] bytes = Encoding.Default.GetBytes(text);
            byte[] hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
