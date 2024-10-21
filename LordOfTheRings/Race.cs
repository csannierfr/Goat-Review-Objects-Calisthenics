namespace LordOfTheRings;

public class Race
{
	public string Value { get; init; }

	private Race(string value)
	{
		Value = value;
	}

	public static Race Create(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new ArgumentException("Character must have a race.");
		}

		return new Race(value);
	}
	
	public override string ToString() => Value;
	
}