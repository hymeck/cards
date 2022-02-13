namespace Data.Entities.Cards;

public sealed class TypeEntity : EntityBase<byte>
{
    public string Value { get; set; } = "";
    public override string ToString() => Value ?? "";
}
