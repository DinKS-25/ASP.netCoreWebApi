using Entities.Models;

namespace Contracts
{
    public interface ICompanyRepository
    {
        public IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompany(string companyId,bool trackChanges);
    }
}