using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Models
{
    public class Character
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("charcterName")]
        public string CharacterName { get; set; }
        [BsonElement("playerName")]
        public string PlayerName { get; set; }

        [BsonElement("level")]
        public int Level { get; set; }

        [BsonElement("race")]
       public string Race { get; set; }

       [BsonElement("class")]
       public string Class { get; set; }

       [BsonElement("alignment")]
       public string Alignment { get; set; }

       [BsonElement("strength")]
       public int Strength { get; set; }

       [BsonElement("Dexterity")]
       public int Dexterity { get; set; }

       [BsonElement("Constitution")]
       public int Constitution { get; set; }

       [BsonElement("Intelligence")]
       public int Intelligence { get; set; }

       [BsonElement("Wisdom")]
       public int Wisdom { get; set; }

       [BsonElement("Charisma")]
       public int Charisma { get; set; }

       [BsonElement("Proficiency")]
       public int Proficiency { get; set; }

       [BsonElement("Speed")]
       public int Speed { get; set; }

       [BsonElement("background")]
       public string Background{ get; set; }
       
       [BsonElement("acrobatics")]
       public List<string> acrobatics { get; set; }

        [BsonElement("animalhandling")]
       public List<string> animalhandling { get; set; }

        [BsonElement("arcana")]
       public List<string> arcana { get; set; }

        [BsonElement("athletics")]
       public List<string> athletics { get; set; }

        [BsonElement("deception")]
       public List<string> deception { get; set; }

        [BsonElement("history")]
       public List<string> history { get; set; }

        [BsonElement("insight")]
       public List<string> insight { get; set; }

        [BsonElement("intimidation")]
       public List<string> intimidation { get; set; }

        [BsonElement("investigation")]
       public List<string> investigation { get; set; }

        [BsonElement("medicine")]
       public List<string> medicine { get; set; }

        [BsonElement("nature")]
       public List<string> nature { get; set; }

        [BsonElement("perception")]
       public List<string> perception { get; set; }

        [BsonElement("performance")]
       public List<string> performance { get; set; }

        [BsonElement("persuasion")]
       public List<string> persuasion { get; set; }

        [BsonElement("religion")]
       public List<string> religion { get; set; }

        [BsonElement("slightofhand")]
       public List<string> slightofhand { get; set; }

        [BsonElement("stealth")]
       public List<string> stealth { get; set; }

        [BsonElement("survival")]
       public List<string> survival { get; set; }

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