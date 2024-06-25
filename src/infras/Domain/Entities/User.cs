using Domain.Enums;

namespace Domain.Entities;
public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    //public string HashPassword { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string FullName
    {
        get => $"{LastName} {FirstName}";
    }

    public RoleEnum Role { get; set; } = RoleEnum.User;
    public ICollection<Order> Orders { get; set; } = default!;





}