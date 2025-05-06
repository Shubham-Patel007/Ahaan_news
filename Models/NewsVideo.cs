namespace AhaanNews.Models
{
    public class NewsVideo
    {
        public Guid NewsId { get; set; }
        public News News { get; set; }

        public Guid VideoId { get; set; }
        public Video Video { get; set; }
    }
}
