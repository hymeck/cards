namespace Data.Entities.Cards;

public sealed class ExampleEntity : EntityBase<long>
{
    public string Value { get; set; } = "";
    public override string ToString() => Value ?? "";
}
