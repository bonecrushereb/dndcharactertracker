using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Models
{
    public class Character
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        
        [BsonElement("name")]
        public string Name { get; set; } = null;

        [BsonElement("race")]
       public string Race { get; set; } = null;

       [BsonElement("class")]
       public string Class { get; set; } = null;

       [BsonElement("abilities")]
       public string Abilities { get; set; } = null;

       [BsonElement("background")]
       public string Background{ get; set; } = null;
       
       [BsonElement("skillproficiencies")]
       public string Skillproficiencies { get; set; } = null;

       [BsonElement("toolproficiencies")]
       public string Toolproficiencies { get; set; } = null;

       [BsonElement("languages")]
       public string Languages { get; set; } = null;

       [BsonElement("personalitytrait")]
       public string PersonalityTrait { get; set; } = null;

       [BsonElement("ideals")]
       public string Ideals { get; set; } = null;
       
        [BsonElement("bonds")]
       public string Bonds { get; set; } = null;

       [BsonElement("flaws")]
       public string Flaws { get; set; } = null;

       [BsonElement("organizations")]
       public string Organizations { get; set; } = null;

       [BsonElement("allies")]
       public string Allies { get; set; } = null;

       [BsonElement("enemies")]
       public string Enemies { get; set; } = null;

       [BsonElement("backstore")]
       public string Backstory { get; set; } = null;

       [BsonElement("equipment")]
       public List<string> Equipment { get; set; } = null;
    }
}