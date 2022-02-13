namespace Data.Entities.Cards;

/// <summary>
/// represents <see cref="CardItemEntity"/> translation to another language.
/// </summary>
public sealed class CardItemTranslationEntity : EntityBase<long>
{
    public string Value { get; set; } = "";
    public CardItemEntity? Item { get; set; }
}
