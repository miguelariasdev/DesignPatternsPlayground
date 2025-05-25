using FactoryMethod.Enums;
using System.Text;

namespace FactoryMethod.Transports;

// Concrete product: Truck
public class Truck : ITransport
{
    public string Deliver(CargoType cargoType, string destination)
    {
        var sb = new StringBuilder();
        sb.AppendLine(CheckTruckCondition());
        sb.Append($"Delivering {cargoType} to {destination} by road.");
        return sb.ToString();
    }

    private string CheckTruckCondition() => "Checking truck condition: OK.";
}