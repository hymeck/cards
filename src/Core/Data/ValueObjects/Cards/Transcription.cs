using LanguageExt;

namespace Data.ValueObjects.Cards;

public sealed record Transcription
{
    public string Value { get; }

    private Transcription(string value) => Value = value;

    public static Either<ArgumentException, Transcription> From(string? value) => (value ?? "") switch
    {
        { } v when string.IsNullOrWhiteSpace(v) => new ArgumentException("empty or whitespace", nameof(value)),
        { Length: > 50 } => new ArgumentException("too long", nameof(value)),
        {} v => new Transcription(v.Trim())
    };
}
