using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galleria.Models
{
    public class Commission
    {
        [Required]
        public int CommissionId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CommissionName { get; set; } = "";

        [Required]
        public int ArtistId { get; set; }

        public string ArtistName { get; set; } = "";

        [Required]
        public int CommissionImageId { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime DatePublished { get; set; }

        [Column(TypeName = "varchar(4000)")]
        public string? Description { get; set; } = "";

        public Commission()
        {

        }

        public Commission(int commissionId, string commissionName, int artistId, string artistName, int commissionImageId, DateTime datePublished, string? description)
        {
            this.CommissionId = commissionId;
            this.CommissionName = commissionName;
            this.ArtistId = artistId;
            this.ArtistName = artistName;
            this.CommissionImageId = commissionImageId;
            this.DatePublished = datePublished;
            this.Description = description;
        }
    }
}
