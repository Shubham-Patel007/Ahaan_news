namespace AhaanNews.Models
{
    public class Video
    {
        public Guid VideoId { get; set; } = Guid.NewGuid();
        public string YoutubeId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime PublishedAt { get; set; }
        public ICollection<NewsVideo> NewsVideos { get; set; }
    }
}
