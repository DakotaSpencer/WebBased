using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galleria.Models
{
    public class Commission
    {
        [Required]
        public int CommissionId { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string CommissionName { get; set; } = "";

        [Required]
        public int ArtistId { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string ArtistName { get; set; } = "";

        public DateTime DatePublished { get; set; }

        [Column(TypeName = "varchar(5000)")]
        public string? Description { get; set; } = "";

        public Commission()
        {

        }

        public Commission(int commissionId, string commissionName, int artistId, string artistName, DateTime datePublished)
        {
            CommissionId = commissionId;
            CommissionName = commissionName;
            ArtistId = artistId;
            ArtistName = artistName;
            DatePublished = datePublished;
        }

        public Commission(int commissionId, string commissionName, int artistId, string artistName, DateTime datePublished, string? description)
        {
            CommissionId = commissionId;
            CommissionName = commissionName;
            ArtistId = artistId;
            ArtistName = artistName;
            DatePublished = datePublished;
            Description = description;
        }
    }
}
