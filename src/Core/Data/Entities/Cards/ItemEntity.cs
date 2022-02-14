namespace Data.Entities.Cards;

/// <summary>
/// core entity. represents a card item.
/// </summary>
public sealed class ItemEntity : EntityBase<int>
{
    public string Content { get; set; } = "";
    public bool Deleted { get; set; }
    public override string ToString() => Content ?? "";
}
