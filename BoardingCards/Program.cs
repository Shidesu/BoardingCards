using BoardingCards;
using BoardingCards.Journey;
using BoardingCards.Transportation;

var journey = new List<BoardingCard>()
{
    new("Paris", "Beyrouth", new Train
    {
        Seat = "26A",
        Comments = "Night train. Enjoy your sleep.",
        TrainNumber = "78A"
    }),
    new("Berlin", "Nice", new Bus
    {
        BusLine = "500",
        Seat = "5B",
    }),
    new("Tunis", "Constantinople", new Bus
    {
        BusLine = "26S"
    }),
    new("Beyrouth", "Tunis", new Plane
    {
        Seat = "10D",
        Comments = "No food allowed onboard.",
        GateNumber = "4C",
        TicketCounter = "344",
        FlightNumber = "SK22"
    }),
    new("Constantinople", "Moscou", new Bus
    {
        BusLine = "630"
    }),
    new("Nice", "Paris", new Bus
    {
        BusLine = "720"
    }),
};

var planner = new JourneyPlanner(journey);

planner.PrintJourney();
