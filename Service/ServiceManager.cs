using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _companyService = new Lazy<ICompanyService>(() => new CompanyService(repositoryManager, logger));
        }
        public ICompanyService CompanyService => _companyService.Value;
    }
}