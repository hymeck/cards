namespace Data.Entities.Cards;

/// <summary>
/// represents audit information of <see cref="ItemEntity"/>.
/// </summary>
public sealed class AuditEntity : EntityBase<long>
{
    public DateTime Added { get; set; }
    public DateTime Modified { get; set; }
    public ItemEntity? Item { get; set; }
}
