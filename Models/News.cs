namespace AhaanNews.Models
{
    public class News
    {
        public Guid NewsId { get; set; } = Guid.NewGuid();
        public string? Headline { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public string Category { get; set; }
        public int LikeCount { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public DateTime PublishedAt { get; set; }

        public ICollection<UserLikedNews> LikedBy { get; set; }
        public ICollection<UserBookmarkedNews> BookmarkedBy { get; set; }
        public ICollection<NewsVideo> Videos { get; set; }
    }
}
