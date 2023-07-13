using System.Linq;
using Contracts;
using Entities.Models;
namespace Repository 
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateCompany(Company company)
        {   var guid = Convert.ToString(System.Guid.NewGuid());
            company._id=guid;
            Create(company);
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(c=>c.name).ToList();
        }

        public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
        {
            IEnumerable<string> stringIds = ids.Select(id => id.ToString()).ToList();
            return FindByCondition(x =>stringIds.Contains(x._id), trackChanges).ToList();
        }

        public Company GetCompany(string companyId,bool trackChanges){
            return FindByCondition(c => c._id!.Equals(companyId), trackChanges).SingleOrDefault()!;
        }
    }
}