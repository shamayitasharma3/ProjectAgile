using Agile_Project_Management_Portal.BLL.DTOs;
using Agile_Project_Management_Portal.DAL.Models;

namespace Agile_Project_Management_Portal.BLL.Services
{
    public interface IDefectServices
    {
        public bool InsertDefect(DefectDTO defect);
        public void UpdateDefect(int id, DefectDTO defect);

        public DefectDTO DefectAssignedTo(string devId);

        public DefectDTO GetDefectById(int id);

        public List<DefectDTO> GetDefectDetails();
    }
}
