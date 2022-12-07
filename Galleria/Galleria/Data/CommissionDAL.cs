using Galleria.Models; 
using Galleria.Interfaces;

namespace Galleria.Data
{
    public class CommissionDAL : IDataAccessLayer
    {
        public GalleriaContext db;

        public CommissionDAL(GalleriaContext db)
        {
            this.db = db;
        }

        public Commissions GetCommission(int? id)
        {
            return db.Commissions.FirstOrDefault(commission => commission.CommissionId == id);
        }

        public IEnumerable<Commissions> GetCommissions()
        {
            return db.Commissions.ToList();
        }

        public IEnumerable<Commissions> SearchCommissions (string strCommissionSearch)
        {
            List<Commissions> foundCommissions = new List<Commissions>();

            foreach (var commission in db.Commissions)
            {
                if (commission.CommissionName.ToUpper().Contains(strCommissionSearch.ToUpper()))
                {
                    foundCommissions.Add(commission);
                }
            }

            return foundCommissions;
        }

        public void AddCommission(Commissions commission)
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

        public IEnumerable<Users> GetUsers()
        {
            return db.Users.ToList();
        }

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
        
        public void UpdateUser(Users user)
        {
            db.Update(user);
            db.SaveChanges();
        }

        public void AddUser(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
