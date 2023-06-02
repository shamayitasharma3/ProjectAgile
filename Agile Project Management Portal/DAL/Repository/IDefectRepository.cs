using Agile_Project_Management_Portal.DAL.Models;

namespace Agile_Project_Management_Portal.Repository
{
    public interface IDefectRepository
    {
        public bool InsertDefect(Defect defect);
        public void UpdateDefect(int id, Defect defect);

        public Defect DefectAssignedTo(string devId);

        public Defect GetDefectById(int id);

        public List<Defect> GetDefectDetails();
    }
}
