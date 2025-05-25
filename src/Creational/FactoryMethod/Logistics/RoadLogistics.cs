using FactoryMethod.Transports;

namespace FactoryMethod.Logistics;

// Concrete creator A
public class RoadLogistics : Logistics
{
    protected override ITransport CreateTransport() => new Truck();

    protected override string PerformPreChecks() =>
        "Checking traffic conditions: Moderate traffic.";
}