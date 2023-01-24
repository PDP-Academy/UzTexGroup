namespace UzTexGroup.Domain.Entities;

public class Factory
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Guid CompanyId { get; set; }

    public Company? Company { get; set; }

    public Guid AddressId { get; set; }

    public Address? Address { get; set; }
    public ICollection<Jobs> Jobs { get; set; }

}
