namespace AhaanNews.Models
{
    public class UserBookmarkedNews
    {
        public Guid UId { get; set; }
        public User User { get; set; }
        public Guid NewsId { get; set; }
        public News News { get; set; }
        public DateTime BookmarkedAt { get; set; } = DateTime.Now;
    }
}
