

using Domain.Enums;

namespace Domain.Entities;
public class Order : BaseEntity
{
    
    public decimal TotalAmount { get; set; }
    public OrderStatusEnum OrderStatusEnum { get; set; } = OrderStatusEnum.Created;

    public Guid UserId { get; set; }
    public User User { get; set; } = default!;
    public ICollection<Ticket> Tickets { get; set; } = default!;
    public ICollection<Payment> Payments { get; set; } = default!;
}