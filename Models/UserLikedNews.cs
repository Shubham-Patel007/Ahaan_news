namespace AhaanNews.Models
{
    public class UserLikedNews
    {
        public Guid UId { get; set; }
        public User User { get; set; }
        public Guid NewsId { get; set; }
        public News News { get; set; }
        public DateTime LikedAt { get; set; } = DateTime.Now;
    }
}
