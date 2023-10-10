namespace BoardingCards.Exceptions;

/// <summary>
/// Represents error that occurs when no place of destination could be found in the journey steps
/// </summary>
public class NoJourneyEndException : Exception
{
    public NoJourneyEndException()
    {
    }

    public NoJourneyEndException(string? message) : base(message)
    {
    }

    public NoJourneyEndException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}