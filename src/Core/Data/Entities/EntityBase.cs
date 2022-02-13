namespace Data.Entities;

/// <summary>
/// base class for entities.
/// </summary>
/// <typeparam name="TId">type of an entity identifier.</typeparam>
public abstract class EntityBase<TId> : IEquatable<EntityBase<TId>?>
{
    public virtual TId Id { get; set; }

    public bool Equals(EntityBase<TId>? other) =>
        other switch
        {
            { } e => EqualityComparer<TId>.Default.Equals(Id, e.Id),
            _ => false
        };

    public sealed override bool Equals(object? obj) => Equals(obj as EntityBase<TId>);

    public sealed override int GetHashCode() => EqualityComparer<TId>.Default.GetHashCode(Id);

    public static bool operator ==(EntityBase<TId>? that, EntityBase<TId>? other) => that?.Equals(other) ?? false;
    public static bool operator !=(EntityBase<TId>? that, EntityBase<TId>? other) => !that?.Equals(other) ?? false;
}
