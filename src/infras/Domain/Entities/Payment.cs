namespace Domain.Entities;
public class Payment : BaseEntity
{
    public decimal Amount { get; set; }
    public bool IsPay { get; set; } = false;
    #region DataVnPayStorage
    public string TxnRef { get; set; } = string.Empty;
    public string TransactionNo { get; set; } = string.Empty;
    public string TransactionDate { get; set; } = string.Empty;
    #endregion
    public Guid OrderId { get; set; }
    public Order Order { get; set; } = default!;
}