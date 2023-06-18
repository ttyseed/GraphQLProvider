using System.ComponentModel.DataAnnotations;

namespace GraphQLSampleAPI.Model
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Please specify a name for the superhero")]
        public string Username { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }   
        public DateTime CreatedDatetime { get; set; }
        public string CreatedById { get; set; } 
        public string CreatedByName { get; set; }
        public DateTime? UpdatedDatetime { get; set; }
        public string? UpdatedById { get; set; }
        public string? UpdatedByName { get; set; }
    }
}
