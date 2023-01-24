namespace UzTexGroup.Domain.Entities;

public class Company
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public DateOnly FoundedAt { get; set; }
    public int EmployeeCount { get; set; }

}
