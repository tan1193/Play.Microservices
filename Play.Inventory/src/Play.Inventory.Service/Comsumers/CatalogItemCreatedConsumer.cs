using MassTransit;
using Play.Common;
using Play.Inventory.Service.Entities;
using Play.Catalog.Contracts;
namespace Play.Inventory.Service.Consumers
{
    public class CatalogItemUpdatedConsumer : IConsumer<CatalogItemCreated>
    {
        private readonly IRepository<CatalogItem> repository;
        public CatalogItemUpdatedConsumer(IRepository<CatalogItem> repository)
        {
            this.repository = repository;
        }
        public async Task Consume(ConsumeContext<CatalogItemCreated> context)
        {
            var message = context.Message;
            var item = await repository.GetAsync(message.ItemId);
            if (item is not null)
            {
                return;
            }
            item = new CatalogItem
            {
                Id = message.ItemId,
                Name = message.Name,
                Description = message.Description
            };
            await repository.CreateAsync(item);
        }
    }
}
