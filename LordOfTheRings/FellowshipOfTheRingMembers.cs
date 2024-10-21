using System.Collections;

namespace LordOfTheRings;

public class FellowshipOfTheRingMembers
{
	private readonly List<Character> members = new List<Character>();


	public void AddMember(Character character)
	{
		bool exists = members.Any(member => member.Name == character.Name);

		if (exists)
		{
			throw new InvalidOperationException(
				"A character with the same name already exists in the fellowship.");
		}
		else
		{
			members.Add(character);
		}
	}

	public void RemoveMember(string name)
	{
		Character characterToRemove = null;
		foreach (var character in members)
		{
			if (character.Name == Name.Create(name))
			{
				characterToRemove = character;
				break;
			}
		}

		if (characterToRemove == null)
		{
			throw new InvalidOperationException($"No character with the name '{name}' exists in the fellowship.");
		}
		else
		{
			members.Remove(characterToRemove);
		}
	}

	public Character? FindMember(Name memberName)
	{
		return members.FirstOrDefault(p => p.Name == memberName);
	}

	public IEnumerable<Character> Members() => members;
}