using System.ComponentModel.DataAnnotations;
using WebApplication_Movie.Data.Base;

namespace WebApplication_Movie.Models
{
    public class Cinema: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Cinema Logo")]
        [Required(ErrorMessage = "Cinema Logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
