using FactoryMethod.Enums;
using FactoryMethod.Logistics;
using FactoryMethod.Transports;
using LogisticsCreatorClass = FactoryMethod.Logistics.Logistics;

namespace FactoryMethod.Tests;

public class LogisticTest
{
    [Theory]
    [InlineData(typeof(SeaLogistics), CargoType.Food, "Lisbon Port",
        "Delivering Food to Lisbon Port by sea.")]
    [InlineData(typeof(RoadLogistics), CargoType.Clothes, "Madrid",
        "Delivering Clothes to Madrid by road.")]
    public void Logistics_ShouldDeliver_ByCorrectTransport(
        Type logisticsType,
        CargoType cargo,
        string destination,
        string expectedDeliveryLine)
    {
        var logistics = (LogisticsCreatorClass)Activator.CreateInstance(logisticsType)!;

        var output = logistics.PlanDelivery(cargo, destination);

        Assert.Contains(expectedDeliveryLine, output);
    }

    [Fact]
    public void RoadLogistics_ShouldIncludeTrafficCheck()
    {
        var road = new RoadLogistics();
        var output = road.PlanDelivery(CargoType.Furniture, "Seville");

        Assert.Contains("Checking traffic conditions: Moderate traffic.", output);
    }

    [Fact]
    public void SeaLogistics_ShouldIncludeWeatherCheck()
    {
        var sea = new SeaLogistics();
        var output = sea.PlanDelivery(CargoType.ConstructionMaterials, "Barcelona");

        Assert.Contains("Checking weather conditions: Clear skies and calm seas.", output);
    }

    [Fact]
    public void Truck_ShouldCheckConditionBeforeDelivery()
    {
        var truck = new Truck();
        var output = truck.Deliver(CargoType.Electronics, "Valencia");

        Assert.Contains("Checking truck condition: OK.", output);
        Assert.Contains("Delivering Electronics to Valencia by road.", output);
    }
}
