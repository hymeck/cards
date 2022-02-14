using Data.ValueObjects.Cards;

namespace Data.Entities.Cards;

public sealed class ExampleEntity : EntityBase<long>
{
    public ExampleEntity(Example example) => Example = example;
    public Example Example { get; set; }
    public override string ToString() => Example.Value;
}
