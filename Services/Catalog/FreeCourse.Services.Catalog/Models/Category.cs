using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]//MongoDb Id olarak görsün diye.
        [BsonRepresentation(BsonType.ObjectId)] //Mongodb içinde stringi objecte çevirsin diye.
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
