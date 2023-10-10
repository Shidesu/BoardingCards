namespace BoardingCards.Journey;

/// <summary>
/// Represents a step in the journey
/// </summary>
public class JourneyStep
{
    /// <summary>
    /// Wrap a boarding card inside of a journey step.
    /// </summary>
    /// <param name="step"></param>
    public JourneyStep(BoardingCard step)
    {
        Current = step;
    }

    /// <summary>
    /// Previous step of the journey.
    /// Null when current step is the first one.
    /// </summary>
    public JourneyStep? Previous { get; set; }
    /// <summary>
    /// Boarding cart of the current step.
    /// </summary>
    public BoardingCard Current { get; init; }
    /// <summary>
    /// Next step of the journey.
    /// Null when current step is the last one.
    /// </summary>
    public JourneyStep? Next { get; set; }
    /// <summary>
    /// Place of origin.
    /// </summary>
    public string From => Current.From;
    /// <summary>
    /// Place of destination.
    /// </summary>
    public string To => Current.To;

    public override string ToString()
    {
        return $"===\n{Previous?.Current}\n{Current}\n{Next?.Current}";
    }
}