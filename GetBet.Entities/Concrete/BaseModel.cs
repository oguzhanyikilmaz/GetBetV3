using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GetBet.Entities.Concrete
{
    public class BaseModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
