using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Company
    {
        //not adding validation in company class as the validation is added in DTO classes
        public string? _id { get; set; }
        public string? name { get; set; }
        public string? address { get; set; }
        public int employeeCount { get; set; }
    }
}