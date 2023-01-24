namespace UzTexGroup.Domain.Entities;

public class Application
{
    public Guid Id { get; set; }
    public string CandidateFullName { get; set; }
    public string TellNumber { get; set; }
    public string Email { get; set; }
    public string CandidateMessage { get; set; }
    public Guid JobId { get; set; }
    public Jobs? Job { get; set; }
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }

}
