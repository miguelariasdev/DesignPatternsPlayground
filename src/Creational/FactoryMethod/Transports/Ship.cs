using FactoryMethod.Enums;

namespace FactoryMethod.Transports;

// Concrete product: Ship
public class Ship : ITransport
{
    public string Deliver(CargoType cargoType, string destination) =>
        $"Delivering {cargoType} to {destination} by sea.";
}