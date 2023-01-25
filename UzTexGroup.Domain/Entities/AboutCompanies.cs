namespace UzTexGroup.Domain.Entities
{
    public class AboutCompanies
    {
        public Guid Id { get; set; }
        public string TitleUz { get; set; }
        public string? TitleUzC { get; set; }
        public string? TitleEn { get; set; }
        public string? TitleRu { get; set; }
        public string ImageUrl { get; set; }
        public string AboutCompanyUz { get; set; }
        public string? AboutCompanyUzC { get; set; }
        public string? AboutCompanyEn { get; set; }
        public string? AboutCompanyRu { get; set; }
    }
}
