namespace UzTexGroup.Domain.Entities;
public class News
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string TitleUz { get; set; }
    public string? TitleUzC { get; set; }
    public string? TitleEn { get; set; }
    public string? TitleRu { get; set; }
    public string BodyUz { get; set; }
    public string? BodyUzC { get; set; }
    public string? BodyEn { get; set; }
    public string? BodyRu { get; set; }
    public ICollection<NewsImages>? NewImages { get; set; }

}
