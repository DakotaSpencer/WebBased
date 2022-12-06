using Galleria.Models; 
using Galleria.Interfaces;

namespace Galleria.Data
{
    public class CommissionDAL : IDataAccessLayer
    {
        public CommissionContext db;

        public CommissionDAL(CommissionContext db)
        {
            this.db = db;
        }

        public void GetCommission(int? id)
        {
            db.Commissions.FirstOrDefault(commission => commission.CommissionId == id);
        }

        public IEnumerable<CommissionModel> GetCommissions()
        {
            db.SaveChanges();
            return db.Commissions;
        }

        public IEnumerable<CommissionModel> SearchCommissions (string strCommissionSearch)
        {
            List<CommissionModel> foundCommissions = new List<CommissionModel>();

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

        public void AddCommission(CommissionModel commission)
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

        public void GetUser(int? id)
        {
            db.Users.FirstOrDefault(user => user.UserId == id);
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
        
        public void UpdateUser(UserModel user)
        {
            db.Update(user);
            db.SaveChanges();
        }

        public void AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
