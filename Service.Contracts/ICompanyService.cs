
using Entities.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges);
        CompanyDto GetCompany(string companyId, bool trackChanges);
        CompanyDto CreateCompany(CompanyForCreationDto company);
        IEnumerable<CompanyDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        (IEnumerable<CompanyDto> companies, string ids) CreateCompanyCollection(IEnumerable<CompanyForCreationDto> companyCollection);
        void RemoveCompany(Guid companyId, bool trackChanges);
        void UpdateCompany(Guid companyId, CompanyForUpdateDTO companyForUpdate, bool trackChanges);
        (CompanyForUpdateDTO companyTopatch, Company companyEntity) GetEmployeeForPatch(Guid companyId, bool compTrackChanges);
        void SaveChangesForPatch(CompanyForUpdateDTO companyToPatch, Company companyEntity);
    }
}