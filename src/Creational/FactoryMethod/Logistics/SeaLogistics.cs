using FactoryMethod.Transports;

namespace FactoryMethod.Logistics;

// Concrete creator B
public class SeaLogistics : Logistics
{
    protected override ITransport CreateTransport() => new Ship();

    protected override string PerformPreChecks() =>
        "Checking weather conditions: Clear skies and calm seas.";
}