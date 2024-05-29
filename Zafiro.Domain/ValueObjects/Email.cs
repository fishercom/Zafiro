namespace Zafiro.Domain.ValueObjects;

public class Email
{
    private readonly string _value;
    public Email(string value)
    {
        _value = value;
    }

    public string Value()
    {
        return _value;
    }
}
