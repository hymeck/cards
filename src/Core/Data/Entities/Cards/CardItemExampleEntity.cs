namespace Data.Entities.Cards;

/// <summary>
/// represents <see cref="CardItemEntity"/> usage example.
/// </summary>
public sealed class CardItemExampleEntity : EntityBase<long>
{
    public string Value { get; set; } = "";
    public CardItemEntity? Item { get; set; }
}
