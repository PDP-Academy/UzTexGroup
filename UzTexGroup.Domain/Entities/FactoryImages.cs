namespace UzTexGroup.Domain.Entities;

public class FactoryImages
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public Guid FactoryId { get; set; }
    public Factory? Factory { get; set; }
}
