using System.Text;

namespace BoardingCards;

public static class Utils
{
    /// <summary>
    /// Fluent <see cref="List{T}.Add"/> extension method
    /// </summary>
    /// <param name="list"></param>
    /// <param name="element">The object to be added to the end of the <see cref="List{T}"/>. The value can be null for reference types.</param>
    /// <typeparam name="T">Type of the items stored in this list.</typeparam>
    /// <returns>The same instance of list. With the element added to it.</returns>
    public static List<T> Append<T>(this List<T> list, T element)
    {
        list.Add(element);

        return list;
    }
}