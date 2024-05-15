using MongoDB.Bson;

namespace CarFactory.Database.CarParts;

public class Chassis
{
    public ObjectId Id { get; set; }
    public string Model { get; set; }
}