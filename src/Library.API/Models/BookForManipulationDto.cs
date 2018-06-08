using System.ComponentModel.DataAnnotations;

namespace Library.API.Models
{
    public abstract class BookForManipulationDto
    {
        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = "Description cannot be longer than 100 characters")]
        public virtual string Description { get; set; }
    }
}