namespace Shared.DataTransferObjects
{
    public record CompanyDto
    {
        public string _id { get; init; }
        public string NameWithCount { get; init; }
        public string address { get; init; }
    }
}