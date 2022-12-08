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
            var commission = db.Commissions.FirstOrDefault(commission => commission.CommissionId == id);
            if (commission == null) throw new KeyNotFoundException("Commission not found");
            return commission;
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
            commission.CommissionId = db.Commissions.Count() + 1;
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

        public Users GetUser(int? id)
        {
            var user = db.Users.FirstOrDefault(user => user.UserId == id);
            if (user == null) throw new KeyNotFoundException("User not found");
            return user;
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
            db.Users.Update(user);
            db.SaveChanges();
        }

        public void AddUser(Users user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public Users GetUserByEmailAndPassword(string email, string password)
        {
            var foundUser = new Users();

            foreach (var user in db.Users)
            {
                if (user.Email.ToUpper() == email && user.Password == password)
                {
                    foundUser = user;
                }
                else
                {
                    foundUser = null;
                }
            }

            return foundUser;
        }
    }
}
