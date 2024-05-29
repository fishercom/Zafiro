namespace Zafiro.Domain.ValueObjects;

public class Slug
{
    private readonly string _value;
    public Slug(string value)
    {
        _value = value;
    }

    public string Value()
    {
        return _value;
    }
}


