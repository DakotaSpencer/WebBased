using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galleria.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string FirstName { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string LastName { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string UserName { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string Email { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string Password { get; set; } = "";

        public string EmailConfirmed { get; set; } = "";

        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "varchar(50000)")]
        public string? ProfilePictureLink { get; set; } = "";

        [Column(TypeName = "varchar(5000)")]
        public string? Bio { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string? Twitter { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string? Instagram { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string? Tumblr { get; set; } = "";

        public User()
        {

        }
    }
}
