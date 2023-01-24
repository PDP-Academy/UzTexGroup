namespace UzTexGroup.Domain.Entities;
public class Company
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public DateTime FoundedDate { get; set; }
    public int EmployeeCount { get; set; }
    public int ExportingCountriesCount { get; set; }
    public Guid AboutCompanyId { get; set; }
    public AboutCompanies? AboutCompany { get; set; }

    public ICollection<Factory> Factories { get; set; }
}
