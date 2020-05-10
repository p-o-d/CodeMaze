using System.Threading;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }

        IEmployeeRepository Employee { get; }

        void Save();

        Task<int> SaveAsync(CancellationToken cancellationToken);
    }
}
