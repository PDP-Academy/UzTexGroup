namespace UzTexGroup.Domain.Entities;
public class NewImages
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public Guid NewsId { get; set; }

    public News? News { get; set; }
}
