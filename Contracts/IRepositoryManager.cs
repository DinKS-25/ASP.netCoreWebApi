namespace Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository CompanyRepository {get;}
        void Save();
    }
}