namespace Data.Entities.Cards;

public sealed class TranslationEntity : EntityBase<long>
{
    public string Value { get; set; } = "";
    public override string ToString() => Value ?? "";
}
