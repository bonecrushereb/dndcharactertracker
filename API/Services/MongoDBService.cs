using dndCharacters.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace dndCharacters.Services;

public class MongoDBService 
{ 
    private readonly IMongoCollection<Character> _characterCollection;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings) {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _characterCollection = database.GetCollection<Character>(mongoDBSettings.Value.CollectionName);
    }
}