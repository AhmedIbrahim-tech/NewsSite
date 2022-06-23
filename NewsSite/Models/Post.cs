

namespace NewsSite.Models
{
    public class Post
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; }
        public virtual Category Category { get; set; }
    }
}
