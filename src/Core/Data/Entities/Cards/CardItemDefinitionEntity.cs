namespace Data.Entities.Cards;

/// <summary>
/// represents <see cref="CardItemEntity"/> definition.
/// </summary>
public sealed class CardItemDefinitionEntity : EntityBase<long>
{
    public string Value { get; set; } = "";
    public CardItemEntity? Item { get; set; }
}
