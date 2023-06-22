using System.ComponentModel.DataAnnotations;

namespace no.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required()]
        [Display(Name = "Library")]
        public int LibraryId { get; set; }

        [Required(), MaxLength(250)]
        public string Title { get; set; }

        public string Summary { get; set; }

        [Required()]
        public string Author { get; set; }

        [Required(), MaxLength(150)]
        public DateTime Published { get; set; }

        public Library? Library { get; set; }
    }
}
