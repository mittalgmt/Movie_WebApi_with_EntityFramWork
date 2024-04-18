using System.ComponentModel.DataAnnotations;

namespace Movie_WebApi_with_ENtityFramWork.Model
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }


        public int Year { get; set; }
    }
}
