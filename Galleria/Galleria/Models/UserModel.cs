using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Galleria.Models
{
    public class UserModel
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

        [Column(TypeName = "varbinary(MAX")]
        public Image? UserProfilePicture { get; set; }

        [Column(TypeName = "varchar(4000)")]
        public string? Bio { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string? Twitter { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string? Instagram { get; set; } = "";

        [Column(TypeName = "varchar(500)")]
        public string? Tumblr { get; set; } = "";

        public UserModel()
        {

        }

        public UserModel(int userId, string firstName, string lastName, string userName, string email, 
            string password, string emailConfirmed, DateTime dateOfBirth,
            string? bio, string? twitter, string? instagram, string? tumblr, Image? userProfilePicture)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Email = email;
            this.Password = password;
            this.EmailConfirmed = emailConfirmed;
            this.DateOfBirth = dateOfBirth;
            this.Bio = bio;
            this.Twitter = twitter;
            this.Instagram = instagram;
            this.Tumblr = tumblr;
            this.UserProfilePicture = userProfilePicture;
        }
    }
}
