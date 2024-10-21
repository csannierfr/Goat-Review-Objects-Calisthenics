namespace LordOfTheRings;

public record Name
{
	public string Value { get; init; }
	
	private Name(string value)
	{
		Value = value;
	}
	
	public static Name Create(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new ArgumentException("Character must have a name.");
		}
		return new Name(value);
	}

	public override string ToString() => Value;
	
}