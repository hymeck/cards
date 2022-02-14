using Data.ValueObjects.Cards;

namespace Data.Entities.Cards;

public sealed class TranscriptionEntity : EntityBase<int>
{
    public TranscriptionEntity(Transcription transcription) => Transcription = transcription;
    public Transcription Transcription { get; set; }
    public override string ToString() => Transcription.Value;
}
