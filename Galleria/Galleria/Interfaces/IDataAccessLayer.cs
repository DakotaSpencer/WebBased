using Galleria.Models;

namespace Galleria.Interfaces
{
    public interface IDataAccessLayer
    {
        public IEnumerable<Commissions> GetCommissions();

        public IEnumerable<Commissions> SearchCommissions(string strSearchCommission);

        void AddCommission(Commissions commission);

        void DeleteCommission(int? id);

        Commissions GetCommission(int? id);

        void AddUser(User user);

        void DeleteUser(int? id);

        void GetUser(int? id);
    }
}
