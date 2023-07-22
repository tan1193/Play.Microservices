namespace Play.Catalog.Contracts
{
    public record CatalogItemCreatedEvent(Guid ItemId, string Name, string Description);
    public record CatalogItemUpdatedEvent(Guid ItemId, string Name, string Description);
    public record CatalogItemDeletedEvent(Guid ItemId);
}