namespace Domain.Entities;
public class Ticket : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    #region Relationship
    public Guid OrderId { get; set; }
    public Order Order { get; set; } = default!;
    public Guid PostId { get; set; }
    public Post Post { get; set; } = default!;
    #endregion
}