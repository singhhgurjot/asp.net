using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{
    public class BlogModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Content is required.")]
        public string? Content { get; set; }

        public int UserId { get; set; }




    }
}
