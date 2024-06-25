using Domain.Enums;

namespace Domain.Entities;
public class Post : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateStart { get; set; } = DateTime.Now;
    public int Quantity { get; set; } = 0;
    public PostStatusEnum Status { get; set; } = PostStatusEnum.Created;
    public PostTypeEnum Type { get; set; } = PostTypeEnum.Others;
    public string ImageUrls { get; set; } = string.Empty;
    public decimal TicketPrice { get; set; } = 0;
    public ICollection<Ticket> Tickets { get; set; } = default!;

}