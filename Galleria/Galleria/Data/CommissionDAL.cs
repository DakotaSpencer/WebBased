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
    }
}
