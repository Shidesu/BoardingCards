using System.Collections;
using System.Text;
using BoardingCards.Exceptions;

namespace BoardingCards.Journey;

/// <summary>
/// A container for an <see cref="IEnumerable{T}"/> of <see cref="JourneyStep"/>.
/// Allows to travel the steps in the correct order.
/// </summary>
public class Journey : IEnumerable<JourneyStep>
{
    private readonly List<JourneyStep> _steps;
    public JourneyStep JourneyBeginning { get; }
    public JourneyStep JourneyEnd { get; }

    public Journey(IEnumerable<JourneyStep> steps)
    {
        _steps = steps.ToList();
        
        var beginning = _steps.FirstOrDefault(x => x.Previous is null);
        JourneyBeginning = beginning ?? throw new NoJourneyBeginningException();
        
        var end = _steps.First(x => x.Next is null);
        JourneyEnd = end ?? throw new NoJourneyEndException();
    }

    public IEnumerator<JourneyStep> GetEnumerator()
    {
        return new StepEnumerator(JourneyBeginning);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine("Here is a summary of your journey:");
        
        foreach (var step in this)
        {
            sb.AppendLine(step.Current.ToString());
        }

        sb.AppendLine("You have arrived at your final destination!");

        return sb.ToString();
    }
}