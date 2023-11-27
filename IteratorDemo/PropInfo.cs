namespace IteratorDemo;

public static class PropInfo
{
    public static IEnumerable<(string Name, object? Value, Type Type)> GetProperties(this object obj)
    {
        return obj
            .GetType()
            .GetProperties()
            .Select(p => (p.Name, p.GetValue(obj), p.PropertyType));
    }
}