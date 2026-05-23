namespace Itmo.ObjectOrientedProgramming.ValueObjects;

public record UserName
{
    public UserName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value), "Name cannot be null or empty.");
        }

        Value = value;
    }

    public string Value { get; }
}