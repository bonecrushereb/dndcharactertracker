using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Models
{
    public class Character
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("level")]
        public int Level { get; set; }

        [BsonElement("race")]
       public string Race { get; set; }

       [BsonElement("class")]
       public string Class { get; set; }

       [BsonElement("abilities")]
       public string Abilities { get; set; }

       [BsonElement("background")]
       public string Background{ get; set; }
       
       [BsonElement("skillproficiencies")]
       public string Skillproficiencies { get; set; }

       [BsonElement("toolproficiencies")]
       public string Toolproficiencies { get; set; }

       [BsonElement("languages")]
       public string Languages { get; set; }

       [BsonElement("personalitytrait")]
       public string PersonalityTrait { get; set; }

       [BsonElement("ideals")]
       public string Ideals { get; set; }
       
        [BsonElement("bonds")]
       public string Bonds { get; set; }

       [BsonElement("flaws")]
       public string Flaws { get; set; }

       [BsonElement("organizations")]
       public string Organizations { get; set; }

       [BsonElement("allies")]
       public string Allies { get; set; }

       [BsonElement("enemies")]
       public string Enemies { get; set; }

       [BsonElement("backstore")]
       public string Backstory { get; set; }

       [BsonElement("equipment")]
       public List<string> Equipment { get; set; }
    }
}