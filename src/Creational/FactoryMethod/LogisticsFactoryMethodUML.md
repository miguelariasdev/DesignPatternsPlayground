# Factory-Method – class diagram

```mermaid
classDiagram
    direction LR

    class Logistics {
        +PlanDelivery()
        #CreateTransport()
        #PerformPreChecks()
    }

    class RoadLogistics
    class SeaLogistics
    Logistics <|-- RoadLogistics
    Logistics <|-- SeaLogistics

    class ITransport {
        <<interface>>
        +Deliver()
    }

    class Truck {
        +Deliver()
        -CheckTruckCondition()
    }

    class Ship {
        +Deliver()
    }
    ITransport <|.. Truck
    ITransport <|.. Ship

    class CargoType {
        <<enumeration>>
        Electronics
        Food
        ConstructionMaterials
        Furniture
        Clothes
    }

    Logistics --> ITransport : «creates»