using LanguageExt;

namespace Data.ValueObjects.Cards;

public sealed record Example
{
    public string Value { get; }

    private Example(string value) => Value = value;

    public static Either<ArgumentException, Example> From(string? value) => (value ?? "") switch
    {
        { } v when string.IsNullOrWhiteSpace(v) => new ArgumentException("empty or whitespace", nameof(value)),
        { Length: > 255 } => new ArgumentException("too long", nameof(value)),
        {} v => new Example(v.Trim())
    };
}
