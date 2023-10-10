namespace BoardingCards.Transportation;

/// <summary>
/// Exposes method for Means of Transportation that can be used during a <see cref="Journey"/>.
/// </summary>
public interface IMeansOfTransportation
{
    /// <summary>
    /// Type of transportation (plane, train, etc.)
    /// </summary>
    public string Type { get; }
    /// <summary>
    /// Get textual details about the means of Transportation
    /// </summary>
    public string Details { get; }
    /// <summary>
    /// Seat number.
    /// </summary>
    public string? Seat { get; init; }
    /// <summary>
    /// Additional comments to add to the boarding card.
    /// </summary>
    public string? Comments { get; init; }
    /// <summary>
    /// Return additional instructions that might depend on the means of transportation.
    /// Can include data such as gate number or the assigned seat, as textual, human readable text.
    /// </summary>
    /// <returns></returns>
    public string? GetInstructions();
}