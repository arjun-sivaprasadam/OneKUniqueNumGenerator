namespace OneKUniqueNumGeneratorAPI.Logic;

public static class UniqueNumberGenerator
{
    /// <summary>
    /// Default: Returns a list of unique integers between <paramref name="rangeMax"/> and <paramref name="rangeMin"/>
    /// </summary>
    /// <param name="count">Total items to be added to the list, Default = 1000</param>
    /// <param name="rangeMin">Minimum range, inclusive lower bound of the list, Default = <see cref="ushort.MinValue">0</see></param>
    /// <param name="rangeMax">Maximum range, exclusive upper bound of the list, Default = <see cref="ushort.MaxValue">65535</see></param>
    /// <returns>A List of unique integers with a total count of <paramref name="count"/></returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
    /// <exception cref="StackOverflowException"> When the count and differrence of <paramref name="maxValue"/> and <paramref name="minValue"/> is comparable!.</exception>
    public static IEnumerable<ushort> GetRandomNumbers(ushort count = 1000, ushort rangeMin = ushort.MinValue, ushort rangeMax = ushort.MaxValue, bool keepRandomOrder = false)
    {
        if (count < rangeMin || count > (rangeMax) || count > (rangeMax - rangeMin))
            throw new ArgumentOutOfRangeException(nameof(count), $" count > {rangeMin} and count < {rangeMax} " +
                $"or the count is too large to produce {count} unique values in between the given range!");

        List<ushort> values = new List<ushort>(count);

        for (int i = 0; i < count; i++)
            AddUinqueUshortToList(ref values, rangeMin, rangeMax);

        if (!keepRandomOrder)
            values.Sort();

        return values;
    }

    /// <summary>
    /// Recursive function to add a unique number to the list!
    /// </summary>
    /// <param name="values"></param>
    /// <param name="rangeMin"></param>
    /// <param name="rangeMax"></param>
    private static void AddUinqueUshortToList(ref List<ushort> values, ushort rangeMin, ushort rangeMax)
    {
        ushort v = (ushort)Random.Shared.Next(rangeMin, rangeMax);

        if (!values.Contains(v))
            values.Add(v);
        else // the item is already present try again
            AddUinqueUshortToList(ref values, rangeMin, rangeMax);

    }
}
