namespace Data.Entities.Cards;

/// <summary>
/// represents <see cref="ItemEntity"/> translation to another language.
/// </summary>
public sealed class TranslationEntity : EntityBase<long>
{
    public string Value { get; set; } = "";
    public ItemEntity? Item { get; set; }
    public override string ToString() => Value ?? "";
}
