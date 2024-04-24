using System.ComponentModel.DataAnnotations;

namespace Cikkek_DB.Model
{
    public class Article
    {
        public int ArticleId { get; set; }

        [MaxLength(50)]
        [Required]
        public string? Title { get; set; }
       
        [Required]
        public string? Content { get; set; }
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        //külső kulcs megadása a User táblához kapcsolódáshoz
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
