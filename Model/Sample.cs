using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraphQLSampleAPI.Model
{
    public class Sample
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The movie title is required")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Instructor { get; set; }
        public DateTime ReleaseDate { get; set; }

      
    }
}
