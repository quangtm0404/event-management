namespace Domain.Entities;
public class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool IsDeleted { get; set; } = false;
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public Guid CreatedBy { get; set; } = Guid.Empty;
    public DateTime? ModificationDate { get; set; }
    public Guid ModificationBy { get; set; } = Guid.Empty;
}