namespace BoardingCards.Transportation;

public record Bus : IMeansOfTransportation
{
    public string Type => "Bus";
    public string? Seat { get; init; }
    public string? Comments { get; init; }
    public required string BusLine { get; init; }
    public string Details => $"bus {BusLine}";
    
    public string? GetInstructions()
    {
        return Seat is not null ? $"Sit in seat {Seat}." : "No seat assigned";
    }
}