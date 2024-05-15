using CarFactory.Database;
using CarFactory.Database.CarParts;

using var carFactoryDbContext = new CarFactoryDbContext();
carFactoryDbContext.Database.EnsureCreated();

// Build new chassis
var chassis = new Chassis { Model = "Bentley-Continental-GT" };

// Store the chassis in the factories warehouse
carFactoryDbContext.Chassis.Add(chassis);

// Do the necessary paperwork
carFactoryDbContext.SaveChanges();
