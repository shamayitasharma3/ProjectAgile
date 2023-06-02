
using Agile_Project_Management_Portal.DAL.Models;

namespace Agile_Project_Management_Portal.BLL.DTOs
{
    public class ResolutionDTO
    {
        public int Id { get; set; }
        public int DefectId { get; set; }
        public Defect Defect { get; set; }
        public DateTime ResolutionDate { get; set; }
        public string Resolutionss { get; set; }


        public static explicit operator Resolution(ResolutionDTO dto)
        {
            if (dto == null) return null;
            return new Resolution
            {
                Id = dto.Id,
                DefectId = dto.DefectId,
                Resolutionss = dto.Resolutionss,
                ResolutionDate = dto.ResolutionDate

            };

        }
        public static implicit operator ResolutionDTO(Resolution res)
        {
            if (res == null) return null;
            return new ResolutionDTO
            {
                Id = res.Id,
                DefectId = res.DefectId,
                Resolutionss = res.Resolutionss,
                ResolutionDate = res.ResolutionDate

            };

        }
    }
}
