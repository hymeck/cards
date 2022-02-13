namespace Data.Entities.Cards;

public sealed class TranscriptionEntity : EntityBase<int>
{
    public string Value { get; set; } = "";
    public override string ToString() => Value ?? "";
}
