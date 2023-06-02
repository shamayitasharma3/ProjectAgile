using Agile_Project_Management_Portal.BLL.DTOs;
using Agile_Project_Management_Portal.DAL.Models;
using Agile_Project_Management_Portal.Repository;

namespace Agile_Project_Management_Portal.BLL.Services
{
    public class DefectServices : IDefectServices
    {
        public readonly IDefectRepository defectrepo;
        public DefectServices(IDefectRepository defectrepo)
        {
            this.defectrepo = defectrepo;
        }

        public DefectDTO DefectAssignedTo(string devId)
        {
            return defectrepo.DefectAssignedTo(devId);
        }

        public DefectDTO GetDefectById(int id)
        {
            return defectrepo.GetDefectById(id);
        }


        public List<DefectDTO> GetDefectDetails()
        {
            return defectrepo.GetDefectDetails().Select(Defect => (DefectDTO)Defect).ToList();
        }

        public bool InsertDefect(DefectDTO defect)
        {
            return defectrepo.InsertDefect((Defect)defect);
        }

        public void UpdateDefect(int id, DefectDTO defect)
        {
            defectrepo.UpdateDefect(id, (Defect)defect);
        }
    }
}
