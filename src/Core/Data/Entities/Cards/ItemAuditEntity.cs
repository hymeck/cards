namespace Data.Entities.Cards;

public sealed class ItemAuditEntity : EntityBase<long>
{
    public DateTime Added { get; set; }
    public DateTime Modified { get; set; }
    public ItemEntity? Item { get; set; }
}
