namespace UzTexGroup.Domain.Entities;
public class NewImages
{
    public Guid Id { get; set; }
    public string image_url { get; set; }
    public Guid NewsId { get; set; }
}
