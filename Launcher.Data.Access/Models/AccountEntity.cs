using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Launcher.Data.Access.Models
{
    public class AccountEntity
    {
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
