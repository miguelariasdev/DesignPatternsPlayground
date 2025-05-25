using FactoryMethod.Enums;

namespace FactoryMethod.Transports;

// Common interface for the transports (products)
public interface ITransport
{
    string Deliver(CargoType cargoType, string destination);
}