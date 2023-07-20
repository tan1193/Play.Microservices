using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Play.Common.Settings;

namespace Play.Common.MongoDB
{
    public static class Extensions
    {
        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            services.AddSingleton<IMongoDatabase>(ServiceProvider =>
                    {
                        var configuration = ServiceProvider.GetService<IConfiguration>();
                        var serviceSettings = configuration.GetSection(nameof(ServiceSettings)).Get<ServiceSettings>() ?? new ServiceSettings();
                        var mongoDbSettings = configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>() ?? new MongoDbSettings();
                        var mongoClient = new MongoClient(mongoDbSettings.ConnectionString);
                        return mongoClient.GetDatabase(serviceSettings.ServiceName);
                    });

            BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));
            BsonSerializer.RegisterSerializer(new DateTimeOffsetSerializer(BsonType.String));
            return services;
        }

        public static IServiceCollection AddMongoRepository<T>(this IServiceCollection services, string collectionName)
                where T : IEntity
        {
            services.AddSingleton<IRepository<T>>(ServiceProvider =>
            {
                var database = ServiceProvider.GetService<IMongoDatabase>();
                return new MongoRepository<T>(database!, collectionName);
            });
            return services;
        }
    }
}