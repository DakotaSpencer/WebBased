using Galleria.Models;

namespace Galleria.Interfaces
{
    public interface IDataAccessLayer
    {
        public IEnumerable<Commission> GetCommissions();

        public IEnumerable<Commission> SearchCommissions(string strSearchCommission);

        public IEnumerable<Commission> FilterCommissions(string artistName, string commissionName, DateTime datePublished);

        void AddCommission(Commission commission);

        void DeleteCommission(int? id);

        void GetCommission(int? id);
    }
}
