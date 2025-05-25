using FactoryMethod.Enums;
using FactoryMethod.Transports;
using System.Text;

/// <summary>
/// Factory Method provides an interface for creating objects in a superclass, but allows
/// subclasses to alter the type of objects that will be created.
/// </summary>

namespace FactoryMethod.Logistics;

// Creator class
public abstract class Logistics
{
    // Factory Method : Subclasses implement it
    protected abstract ITransport CreateTransport();

    // Optional hook
    protected virtual string PerformPreChecks() => string.Empty;

    // Template Method: Fixed part that doesn't change
    public string PlanDelivery(CargoType cargoType, string destination)
    {
        var sb = new StringBuilder();
        var pre = PerformPreChecks();
        if (!string.IsNullOrWhiteSpace(pre))
            sb.AppendLine(pre);

        sb.Append(CreateTransport().Deliver(cargoType, destination));

        return sb.ToString();
    }
}