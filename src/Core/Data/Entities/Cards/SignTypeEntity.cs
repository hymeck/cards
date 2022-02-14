using Data.ValueObjects.Cards;

namespace Data.Entities.Cards;

public sealed class SignTypeEntity : EntityBase<byte>
{
    public SignTypeEntity(SignType signType) => SignType = signType;
    public SignType SignType { get; set; }
    public override string ToString() => SignType.Value;
}
