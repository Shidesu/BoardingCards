namespace BoardingCards.Journey;

/// <summary>
/// Journey planner
/// </summary>
public class JourneyPlanner
{
    public Journey Journey { get; }

    /// <summary>
    /// Create a new instance of <see cref="JourneyPlanner"/> for the given boarding cards.
    /// </summary>
    /// <param name="boardingCards">The boarding cards for the journey</param>
    public JourneyPlanner(IEnumerable<BoardingCard> boardingCards)
    {
        Journey = CreateSteps(boardingCards);
    }

    /// <summary>
    /// Build a <see cref="BoardingCards.Journey.Journey"/> from the given boarding cards.
    /// </summary>
    /// <param name="boardingCards">Boarding cards used through the journey.</param>
    /// <returns>A new <see cref="BoardingCards.Journey.Journey"/> based on the boarding cards.</returns>
    private static Journey CreateSteps(IEnumerable<BoardingCard> boardingCards)
    {
       var steps = boardingCards
            .Aggregate(new List<JourneyStep>(), (acc, card) =>
            {
                var step = new JourneyStep(card);
                if (acc.Count is 0)
                    return acc.Append(step);

                var previous = acc.FirstOrDefault(x => x.To == card.From);
                if (previous is not null)
                {
                    previous.Next = step;
                    step.Previous = previous;
                }

                var next = acc.FirstOrDefault(x => x.From == card.To);
                if (next is not null)
                {
                    next.Previous = step;
                    step.Next = next;
                }

                return acc.Append(step);
            });
       return new Journey(steps);
    }

    /// <summary>
    /// Print the textual summary of the journey.
    /// </summary>
    public void PrintJourney()
    {
        Console.WriteLine(Journey);
    }
}