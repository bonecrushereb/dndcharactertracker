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

    public async Task<List<Character>> GetAsync() =>
        await _characterCollection.Find(_ => true).ToListAsync();

    public async Task<Character> GetAsync(string id) =>
        await _characterCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Character newCharacter) =>
        await _characterCollection.InsertOneAsync(newCharacter);

    public async Task UpdateAsync(string id, Character updatedCharacter) =>
        await _characterCollection.ReplaceOneAsync(updatedCharacter => updatedCharacter.Id == id, updatedCharacter);

    public async Task RemoveAsync(string id) =>
        await _characterCollection.DeleteOneAsync(x => x.Id == id);
}