namespace Data.Entities.Cards;

public sealed class SignTypeEntity : EntityBase<byte>
{
    public string Value { get; set; } = "";
    public override string ToString() => Value ?? "";
}
