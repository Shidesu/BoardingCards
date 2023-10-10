namespace BoardingCards.Transportation;

public record Train : IMeansOfTransportation
{
    public string Type => "Train";
    public string? Seat { get; init; }
    public string? Comments { get; init; }
    public required string TrainNumber { get; init; }
    public string Details => $"train {TrainNumber}";
    
    public string? GetInstructions()
    {
        return $"Sit in seat {Seat}.";
    }
}