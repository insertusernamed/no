using System.ComponentModel.DataAnnotations;

namespace no.Models
{
    public class Library
    {
        public int Id { get; set; }

        [Required(), MaxLength(250)]
        public string Name { get; set; }

        [Required(), MaxLength(1000)]
        [Display(Name = "Library Address")]
        public string Location { get; set; }

        [Required(), MaxLength(300)]
        [Display(Name= "Website URL")]
        public string Website { get; set; }

        [Required()]
        public DateTime Created { get; set; }

        public List<Book>? Books { get; set; }
    }
}
