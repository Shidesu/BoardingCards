namespace BoardingCards.Exceptions;

/// <summary>
/// Represents error that occurs when no place of origin could be found in the journey steps
/// </summary>
public class NoJourneyBeginningException : Exception
{
    public NoJourneyBeginningException()
    {
    }

    public NoJourneyBeginningException(string? message) : base(message)
    {
    }

    public NoJourneyBeginningException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}