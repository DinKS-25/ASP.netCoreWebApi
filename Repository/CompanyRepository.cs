
using Contracts;
using Entities.Models;
namespace Repository 
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(c=>c.name).ToList();
        }

        public Company GetCompany(string companyId,bool trackChanges){
            return FindByCondition(c => c._id!.Equals(companyId), trackChanges).SingleOrDefault()!;
        }
    }
}