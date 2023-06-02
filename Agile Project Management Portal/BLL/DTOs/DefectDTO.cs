using Agile_Project_Management_Portal.DAL.Models;

namespace Agile_Project_Management_Portal.BLL.DTOs
{
    public class DefectDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DefectDetails { get; set; }
        public string StepsToReproduce { get; set; }
        public string Priority { get; set; }
        public DateTime DetectedOn { get; set; }
        public DateTime ExpectedResolution { get; set; }
        public string ReportedBTesterId { get; set; }
        public string AssignedToDeveloperId { get; set; }
        public string Severity { get; set; }
        public string Status { get; set; }
        public int ProjectCode { get; set; }

        public static implicit operator DefectDTO(Defect dto)
        {
            if (dto == null) return null;
            return new DefectDTO
            {
                Id = dto.Id,
                Title = dto.Title,
                DefectDetails = dto.DefectDetails,
                StepsToReproduce = dto.StepsToReproduce,
                Priority = dto.Priority,
                DetectedOn = dto.DetectedOn,
                ExpectedResolution = dto.ExpectedResolution,
                ReportedBTesterId = dto.ReportedBTesterId,
                AssignedToDeveloperId = dto.AssignedToDeveloperId,
                Severity = dto.Severity,
                Status = dto.Status,
                ProjectCode = dto.ProjectCode
            };
        }
        public static explicit operator Defect(DefectDTO dft)
        {
            if (dft == null) return null;
            return new Defect
            {
                Id = dft.Id,
                Title = dft.Title,
                DefectDetails = dft.DefectDetails,
                StepsToReproduce = dft.StepsToReproduce,
                Priority = dft.Priority,
                DetectedOn = dft.DetectedOn,
                ExpectedResolution = dft.ExpectedResolution,
                ReportedBTesterId = dft.ReportedBTesterId,
                AssignedToDeveloperId = dft.AssignedToDeveloperId,
                Severity = dft.Severity,
                Status = dft.Status,
                ProjectCode = dft.ProjectCode
            };
        }
    }
}
