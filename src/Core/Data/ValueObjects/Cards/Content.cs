using LanguageExt;

namespace Data.ValueObjects.Cards;

public sealed record Content
{
    public string Value { get; }

    private Content(string value) => Value = value;

    public static Either<ArgumentException, Content> From(string? value) => (value ?? "") switch
    {
        { } v when string.IsNullOrWhiteSpace(v) => new ArgumentException("empty or whitespace", nameof(value)),
        { Length: > 100 } => new ArgumentException("too long", nameof(value)),
        {} v => new Content(v.Trim())
    };
}
