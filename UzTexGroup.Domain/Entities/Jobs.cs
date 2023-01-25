namespace UzTexGroup.Domain.Entities;

public class Jobs
{
    public Guid Id { get; set; }
    public string JobName { get; set; }
    public string WorkTime { get; set; }
    public decimal Salary { get; set; }
    public string Requirement { get; set; }
    public Guid FactoryId { get; set; }
    public Factory Factory { get; set; }

    public ICollection<Application> Applications { get; set; }
}
