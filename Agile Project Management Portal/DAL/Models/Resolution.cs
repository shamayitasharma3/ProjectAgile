using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agile_Project_Management_Portal.DAL.Models
{
    public class Resolution
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Defect")]
        [MaxLength(10)]
        public int DefectId { get; set; }
        public Defect Defect { get; set; }

        public DateTime ResolutionDate { get; set; }

        [StringLength(500)]
        public string Resolutionss { get; set; }
    }
}
