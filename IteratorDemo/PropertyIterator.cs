using System.Collections;
using System.Reflection;

namespace IteratorDemo;

public class PropertyIterator : IEnumerable<(string Name, object? Value, Type Type)>
{
    private readonly List<(string Name, object? Value, Type Type)> _list;

    public PropertyIterator(object obj)
    {
        _list = obj
            .GetType()
            .GetProperties()
            .Select(prop => (prop.Name, prop.GetValue(obj), prop.PropertyType))
            .ToList();
    }

    public IEnumerator<(string Name, object? Value, Type Type)> GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}