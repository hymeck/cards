using Data.ValueObjects.Cards;

namespace Data.Entities.Cards;

public sealed class TranslationEntity : EntityBase<long>
{
    public TranslationEntity(Translation translation) => Translation = translation;
    public Translation Translation { get; set; }
    public override string ToString() => Translation.Value;
}
