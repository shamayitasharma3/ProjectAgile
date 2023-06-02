using Agile_Project_Management_Portal.DAL.Data;
using Agile_Project_Management_Portal.DAL.Models;

namespace Agile_Project_Management_Portal.Repository
{
    public class DefectRepository : IDefectRepository
    {
        AppDbContext db;

        public DefectRepository(AppDbContext db) 
        {
            this.db = db;
        }

        public Defect DefectAssignedTo(string devId)
        {
            return db.Defects.SingleOrDefault(x => x.AssignedToDeveloperId == devId);
        }

        public Defect GetDefectById(int id)
        {
            return db.Defects.SingleOrDefault(x => x.Id == id);
        }

        public List<Defect> GetDefectDetails()
        {
            return db.Defects.ToList();
        }

        public bool InsertDefect(Defect defect)
        {
            db.Defects.Add(defect);
            return db.SaveChanges() > 0;
        }

        public void UpdateDefect(int id, Defect updateDefect)
        {
            Defect defect = db.Defects.SingleOrDefault(x => x.Id == id);
            if (defect != null)
                defect = updateDefect;
            db.SaveChanges();
        }


    }
}
