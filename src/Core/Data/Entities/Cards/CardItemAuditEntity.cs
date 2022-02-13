namespace Data.Entities.Cards;

public sealed class CardItemAuditEntity : EntityBase<long>
{
    public DateTime Added { get; set; }
    public DateTime Modified { get; set; }
    public CardItemEntity? Item { get; set; }
}
