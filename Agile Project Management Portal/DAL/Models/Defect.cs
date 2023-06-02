using System.ComponentModel.DataAnnotations;

namespace Agile_Project_Management_Portal.DAL.Models
{
    public class Defect
    {
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string DefectDetails { get; set; }

        [StringLength(1000)]
        public string StepsToReproduce { get; set; }

        [StringLength(2)]
        [RegularExpression("P1|P2|P3")]
        public string Priority { get; set; }

        public DateTime DetectedOn { get; set; }

        public DateTime ExpectedResolution { get; set; }

        [StringLength(6)]
        public string ReportedBTesterId { get; set; }

        [StringLength(6)]
        public string AssignedToDeveloperId { get; set; }

        [StringLength(15)]
        [RegularExpression("Blocker|Critical|Major|Minor|Low")]
        public string Severity { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [MaxLength(10)]
        public int ProjectCode { get; set; }

    }
        
}
