using LanguageExt;

namespace Data.ValueObjects.Cards;

public sealed record Translation
{
    public string Value { get; }

    private Translation(string value) => Value = value;

    public static Either<ArgumentException, Translation> From(string? value) => (value ?? "") switch
    {
        { } v when string.IsNullOrWhiteSpace(v) => new ArgumentException("empty or whitespace", nameof(value)),
        { Length: > 50 } => new ArgumentException("too long", nameof(value)),
        {} v => new Translation(v.Trim())
    };
}
