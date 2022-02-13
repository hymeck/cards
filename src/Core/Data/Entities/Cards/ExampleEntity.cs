namespace Data.Entities.Cards;

/// <summary>
/// represents <see cref="ItemEntity"/> usage example.
/// </summary>
public sealed class ExampleEntity : EntityBase<long>
{
    public string Value { get; set; } = "";
    public ItemEntity? Item { get; set; }
    public override string ToString() => Value ?? "";
}
