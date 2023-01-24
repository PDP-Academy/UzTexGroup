using UzTexGroup.Domain.Enums;

namespace UzTexGroup.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
    public Role UserRole { get; set; }
}
