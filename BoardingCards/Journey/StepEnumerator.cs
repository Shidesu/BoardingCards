using System.Collections;

namespace BoardingCards.Journey;

/// <summary>
/// An <see cref="IEnumerator{T}"/> for <see cref="JourneyStep"/>.
/// Used by <see cref="Journey"/> to travel journey steps in correct order.
/// </summary>
internal class StepEnumerator : IEnumerator<JourneyStep>
{
    private JourneyStep Origin { get; init; }
    private bool _firstCall = true;

    public StepEnumerator(JourneyStep origin)
    {
        Origin = origin;
        Current = Origin;
    }

    /// <inheritdoc cref="MoveNext"/>
    public bool MoveNext()
    {
        if (_firstCall)
        {
            _firstCall = false;
            return true;
        }

        if (Current.Next is null)
            return false;

        Current = Current.Next;
        return true;
    }

    /// <inheritdoc cref="Reset"/>
    public void Reset()
    {
        Current = Origin;
    }

    public JourneyStep Current { get; private set; }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
}