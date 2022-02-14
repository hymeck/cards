using Data.ValueObjects.Cards;

namespace Data.Entities.Cards;

public sealed class DefinitionEntity : EntityBase<long>
{
    public DefinitionEntity(Definition definition) => Definition = definition;
    public Definition Definition { get; set; }
    public override string ToString() => Definition.Value;
}
