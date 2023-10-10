using BoardingCards.Transportation;

namespace BoardingCards;

/// <summary>
/// Represents boarding card data.
/// </summary>
/// <param name="From">Place of origin.</param>
/// <param name="To">Place of destination.</param>
/// <param name="MeansOfTransportation">The means of transportation used to reach destination.</param>
public record BoardingCard(string From, string To, IMeansOfTransportation MeansOfTransportation)
{
    public override string ToString()
    {
        return $"Take {MeansOfTransportation.Details} from {From} to {To}. {MeansOfTransportation.GetInstructions()} {MeansOfTransportation.Comments}";
    }
};