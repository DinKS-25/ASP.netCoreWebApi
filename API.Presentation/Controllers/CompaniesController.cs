using System.Linq.Expressions;
using API.Presentation.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace API.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CompaniesController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetCompanies()
        {
            var companies = _service.CompanyService.GetAllCompanies(trackChanges: false);
            return Ok(companies);
        }

        [HttpGet("{id}", Name = "CompanyById")]
        public IActionResult GetActionResult(string id)
        {
            var company = _service.CompanyService.GetCompany(id, trackChanges: false);
            return Ok(company);
        }

        [HttpPost]
        public IActionResult CreateCompany([FromBody] CompanyForCreationDto company)
        {
            if (company is null)
                return BadRequest("CompanyForCreationDto object is null");
            var createdCompany = _service.CompanyService.CreateCompany(company);
            return CreatedAtRoute("CompanyById", new { id = createdCompany._id },
            createdCompany);
        }

        [HttpGet("collection/({ids})", Name = "CompanyCollection")]
        public IActionResult GetCompanyCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            var companies = _service.CompanyService.GetByIds(ids, trackChanges: false);

            return Ok(companies);
        }

        [HttpPost("collection")]
        public IActionResult CreateCompanyCollection([FromBody] IEnumerable<CompanyForCreationDto> companyCollection)
        {
            var result =
            _service.CompanyService.CreateCompanyCollection(companyCollection);
            return CreatedAtRoute("CompanyCollection", new { result.ids },
            result.companies);
        }

        [HttpDelete("{companyId:guid}")]
        public IActionResult DeleteCompany(Guid companyId)
        {
            _service.CompanyService.RemoveCompany(companyId, trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateEmployeeForCompany(Guid id,[FromBody] CompanyForUpdateDTO companyForUpdate)
        {
            if (companyForUpdate is null)
                return BadRequest("companyForUpdate object is null");
            _service.CompanyService.UpdateCompany(id,companyForUpdate, trackChanges: true);
            return NoContent();
        }
    }
}