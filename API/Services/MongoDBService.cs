using API.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;

namespace API.Services;

public class MongoDBService 
{ 
    private readonly IMongoCollection<Character> _characterCollection;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings) {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _characterCollection = database.GetCollection<Character>(mongoDBSettings.Value.CollectionName);
    }

    public async Task CreateCharacter(Character character) {
        await _characterCollection.InsertOneAsync(character);
        return;
    }

    public async Task<List<Character>> GetCharacters() {
        return await _characterCollection.Find(new BsonDocument()).ToListAsync();
    }

    public async Task<List<Character>> GetCharacter(string id) {
        var filter = Builders<Character>.Filter.Eq("Id", id);
        return await _characterCollection.Find(filter).ToListAsync();
    }

    public async Task EditCharacter(string id, string characterId) {
        FilterDefinition<Character> filter = Builders<Character>.Filter.Eq("Id", id);
        UpdateDefinition<Character> update = Builders<Character>.Update.AddToSet<string>("characterId", characterId);
        await _characterCollection.UpdateOneAsync(filter, update);
        return; 
    }

    public async Task DeleteCharacter(string id) {
        FilterDefinition<Character> filter = Builders<Character>.Filter.Eq("Id", id);
        await _characterCollection.DeleteOneAsync(filter);
        return;
    }
}