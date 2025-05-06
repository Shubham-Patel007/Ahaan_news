using System.ComponentModel.DataAnnotations;

namespace AhaanNews.Models
{
    public class User
    {
        [Key]
        public Guid UId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? ProfileImageUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastLogin { get; set; } = DateTime.UtcNow;
        public ICollection<UserLikedNews> Likes { get; set; }
        public ICollection<UserBookmarkedNews> Bookmarks { get; set; }
    }
}
