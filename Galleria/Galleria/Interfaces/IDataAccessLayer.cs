using Galleria.Models;

namespace Galleria.Interfaces
{
    public interface IDataAccessLayer
    {
        public IEnumerable<Commission> GetCommissions();

        public IEnumerable<Commission> SearchCommissions(string strSearchCommission);

        void AddCommission(Commission commission);

        void DeleteCommission(int? id);

        void GetCommission(int? id);
    }
}
