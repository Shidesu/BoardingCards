using System.Text;

namespace BoardingCards.Transportation;

public record Plane : IMeansOfTransportation
{
    public string Type => "Plane";
    public string? Seat { get; init; }
    public string? Comments { get; init; }
    public required string GateNumber { get; init; }
    public required string? TicketCounter { get; init; }
    public required string FlightNumber { get; init; }
    public string Details => $"flight {FlightNumber}";
    
    public string? GetInstructions()
    {
        var sb = new StringBuilder();
        
        sb.Append($"Gate {GateNumber}, seat {Seat}. ");

        if (TicketCounter is null)
            sb.Append("Baggage will be automatically transferred from your last leg.");
        else
            sb.Append($"Baggage drop at ticket counter {TicketCounter}.");

        return sb.ToString();
    }
}