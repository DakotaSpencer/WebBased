using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galleria.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        public string UserName { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; } = "";

        public string EmailConfirmed { get; set; } = "";

        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "varchar(4000)")]
        public string? ProfilePictureLink { get; set; } = "";

        [Column(TypeName = "varchar(4000)")]
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

        public User(int userId, string firstName, string lastName, string userName, string email, 
            string password, string emailConfirmed, DateTime dateOfBirth, string? profilePictureLink, 
            string? bio, string? twitter, string? instagram, string? tumblr)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Password = password;
            EmailConfirmed = emailConfirmed;
            DateOfBirth = dateOfBirth;
            ProfilePictureLink = profilePictureLink;
            Bio = bio;
            Twitter = twitter;
            Instagram = instagram;
            Tumblr = tumblr;
        }
    }
}
