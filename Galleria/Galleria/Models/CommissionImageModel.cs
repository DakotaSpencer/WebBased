using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Galleria.Models
{
    public class CommissionImageModel
    {
        [Required]
        public int CommissionImageId { get; set; }

        [Required]
        public int CommissionId { get; set; }

        [Column(TypeName = "varbinary(MAX)")] 
        public Image CommissionImage { get; set; }

        public CommissionImageModel()
        {

        }

        public CommissionImageModel(int commissionImageId, int commissionId, Image commissionImage)
        {
            this.CommissionImageId = commissionImageId;
            this.CommissionId = commissionId;
            this.CommissionImage = commissionImage;
        }
    }
}