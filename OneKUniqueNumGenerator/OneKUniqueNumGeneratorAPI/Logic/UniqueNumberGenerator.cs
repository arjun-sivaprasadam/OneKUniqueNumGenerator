namespace OneKUniqueNumGeneratorAPI.Logic;

public static class UniqueNumberGenerator
{
    public static IEnumerable<ushort> GetUniqueNumbers(ushort count = 1000, ushort rangeMin = ushort.MinValue, ushort rangeMax = ushort.MaxValue)
    {
        List<ushort> values = new List<ushort>();

        for (int i = 0; i < count; i++)
            AddUinqueUshortToList(ref values, rangeMin, rangeMax);

        return values;
    }

    private static void AddUinqueUshortToList(ref List<ushort> values, ushort rangeMin, ushort rangeMax)
    {
        ushort v = (ushort)Random.Shared.Next(rangeMin, rangeMax);

        if (!values.Contains(v))
            values.Add(v);
        else // the item is already present try again
            AddUinqueUshortToList(ref values, rangeMin, rangeMax);

    }
}
