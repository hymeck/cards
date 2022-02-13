namespace Data.Entities.Cards;

/// <summary>
/// core entity. represents a card item.
/// </summary>
public sealed class CardItemEntity : EntityBase<int>
{
    public string Value { get; set; } = "";
    public bool Deleted { get; set; }
}
