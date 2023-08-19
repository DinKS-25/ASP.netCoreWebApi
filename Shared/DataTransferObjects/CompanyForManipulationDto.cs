
using System.ComponentModel.DataAnnotations;
namespace Shared.DataTransferObjects
{
    public abstract record CompanyForManipulationDto
    {

        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? name{get;init;}
        [Required(ErrorMessage = "Company Count is a required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "Atleast one Employee required")]
        public int employeeCount {get;init;}
        [Required(ErrorMessage = "Company address is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Address is 60 characters")]
        public string? address{get;init;}
    }
}