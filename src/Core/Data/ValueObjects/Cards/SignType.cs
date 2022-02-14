using LanguageExt;

namespace Data.ValueObjects.Cards;

public sealed record SignType
{
    public string Value { get; }

    private SignType(string value) => Value = value;

    public static Either<ArgumentException, SignType> From(string? value) => (value ?? "") switch
    {
        { } v when string.IsNullOrWhiteSpace(v) => new ArgumentException("empty or whitespace", nameof(value)),
        { Length: > 20 } => new ArgumentException("too long", nameof(value)),
        {} v => new SignType(v.Trim())
    };
}
