using Galleria.Models; 
using Galleria.Interfaces;

namespace Galleria.Data
{
    public class CommissionDAL
    {
        private CommissionContext db;

        public CommissionDAL(CommissionContext db)
        {
            this.db = db;
        }

        public Commission GetCommission(int? id)
        {
            return db.Commissions.FirstOrDefault(commission => commission.CommissionId == id);
        }

        public IEnumerable<Commission> GetCommissions()
        {
            db.SaveChanges();
            return db.Commissions;
        }

        public IEnumerable<Commission> Search (string strCommissionSearch)
        {
            List<Commission> foundCommissions = new List<Commission>();

            foreach (var commission in db.Commissions)
            {
                if (commission.ArtistName.ToUpper().Contains(strCommissionSearch.ToUpper()) ||
                    commission.CommissionName.ToUpper().Contains(strCommissionSearch.ToUpper()))
                {
                    foundCommissions.Add(commission);
                }
            }

            return foundCommissions;
        }

        public void AddCommission(Commission commission)
        {
            commission.CommissionId = 0;
            db.Add(commission);
            db.SaveChanges();
        }

        public void DeleteCommission(int? id)
        {
            if (id > 0)
            {
                db.Commissions.Remove(db.Commissions.Find(id));
                db.SaveChanges();
            }
        }

        // --------- User DAL -------------

        public User GetUser(int? id)
        {
            return db.Users.FirstOrDefault(user => user.UserId == id);
        }

        public void DeleteUser(int? id)
        {
            if(id > 0)
            {
                db.Users.Remove(db.Users.Find(id));
                foreach (var commissions in db.Commissions)
                {
                    if(commissions.ArtistId == id)
                    {
                        db.Commissions.Remove(db.Commissions.Find(commissions.ArtistId));
                    }
                }
            }
        }
        
        public void UpdateUser(User user)
        {
            db.Update(user);
            db.SaveChanges();
        }
    }
}
