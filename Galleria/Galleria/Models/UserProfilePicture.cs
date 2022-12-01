using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Galleria.Models
{
    public class UserProfilePicture
    {
        [Required]
        public int UserProfilePictureId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public Image UserProfilePictureImage { get; set; }

        public UserProfilePicture()
        {

        }

        public UserProfilePicture(int userProfilePictureId, int userId, Image userProfilePictureImage)
        {
            UserProfilePictureId = userProfilePictureId;
            UserId = userId;
            UserProfilePictureImage = userProfilePictureImage;
        }
    }
}
