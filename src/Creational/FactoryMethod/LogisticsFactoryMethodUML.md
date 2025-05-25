classDiagram
    direction LR

    class Logistics {
        +string PlanDelivery(CargoType, string)
        #ITransport CreateTransport()
        #string PerformPreChecks()
    }

    class RoadLogistics
    class SeaLogistics
    Logistics <|-- RoadLogistics
    Logistics <|-- SeaLogistics

    interface ITransport {
        +string Deliver(CargoType, string)
    }

    class Truck {
        +string Deliver(CargoType, string)
        -string CheckTruckCondition()
    }
    class Ship {
        +string Deliver(CargoType, string)
    }
    ITransport <|.. Truck
    ITransport <|.. Ship

    enum CargoType {
        Electronics
        Food
        ConstructionMaterials
        Furniture
        Clothes
    }

    Logistics --> ITransport : «creates»