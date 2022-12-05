using Galleria.Models;

namespace Galleria.Interfaces
{
    public interface IDataAccessLayer
    {
        public IEnumerable<CommissionModel> GetCommissions();

        public IEnumerable<CommissionModel> SearchCommissions(string strSearchCommission);

        void AddCommission(CommissionModel commission);

        void DeleteCommission(int? id);

        void GetCommission(int? id);

        void AddUser(UserModel user);

        void DeleteUser(int? id);

        void GetUser(int? id);
    }
}
