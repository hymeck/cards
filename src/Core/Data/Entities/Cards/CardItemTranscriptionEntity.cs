namespace Data.Entities.Cards;

/// <summary>
/// represents <see cref="CardItemEntity"/> transcription.
/// </summary>
public sealed class CardItemTranscriptionEntity : EntityBase<int>
{
    public string Value { get; set; } = "";
    public CardItemEntity? Item { get; set; }
}
