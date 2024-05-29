namespace Zafiro.Domain.ValueObjects;

public class Alias
{
    private readonly string _value;
    public Alias(string value)
    {
        _value = value;
    }

    public string Value()
    {
        return _value;
    }
}


