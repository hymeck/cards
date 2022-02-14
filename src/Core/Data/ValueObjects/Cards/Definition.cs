using LanguageExt;

namespace Data.ValueObjects.Cards;

public sealed record Definition
{
    public string Value { get; }

    private Definition(string value) => Value = value;

    public static Either<ArgumentException, Definition> From(string? value) => (value ?? "") switch
    {
        { } v when string.IsNullOrWhiteSpace(v) => new ArgumentException("empty or whitespace", nameof(value)),
        { Length: > 100 } => new ArgumentException("too long", nameof(value)),
        {} v => new Definition(v.Trim())
    };
}
