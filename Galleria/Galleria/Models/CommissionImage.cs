using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Galleria.Models
{
    public class CommissionImage
    {
        [Required]
        public int CommissionImageId { get; set; }

        [Required]
        public int CommissionId { get; set; }

        [Column(TypeName = "varbinary(MAX)")]
        public Image 
    }
}
