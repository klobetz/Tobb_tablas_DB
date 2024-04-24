using System.ComponentModel.DataAnnotations;

namespace Cikkek_DB.Model
{
    public class User
    {

        public int UserId { get; set; }
    
        [MaxLength(50)]
        [Required]
        public string? Username { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }


        //kapcsolat másik táblázo: Egy user-nek több cikke lehet
        public ICollection<Article> Articles { get; set; }

    }
}
