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

        void AddUser(Users user);

        void DeleteUser(int? id);

        Users GetUser(int? id);

        public IEnumerable<Users> GetUsers();
        public Users GetUserByEmailAndPassword(string email, string password);

    }
}
