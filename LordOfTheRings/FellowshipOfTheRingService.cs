namespace LordOfTheRings
{
	public class FellowshipOfTheRingService
	{
		readonly FellowshipOfTheRingMembers _fellowshipOfTheRingMembers = new FellowshipOfTheRingMembers();

		public void AddMember(Character character)
		{
			_fellowshipOfTheRingMembers.AddMember(character);
		}

		public void RemoveMember(string name)
		{
			_fellowshipOfTheRingMembers.RemoveMember(name);
		}

		public void MoveMembersToRegion(List<Name> memberNames, string region)
		{
			foreach (var name in memberNames)
			{
				foreach (var character in members)
				{
					if (character.Name==name)
					{
						if (character.Region == "Mordor" && region != "Mordor")
						{
							throw new InvalidOperationException(
								$"Cannot move {character.Name} from Mordor to {region}. Reason: There is no coming back from Mordor.");
						}
						else
						{
							character.Region = region;
							if (region != "Mordor") Console.WriteLine($"{character.Name} moved to {region}.");
							else Console.WriteLine($"{character.Name} moved to {region} 💀.");
						}
					}
				}
			}
		}

		public void PrintMembersInRegion(string region)
		{
			List<Character> charactersInRegion = new List<Character>();
			foreach (var character in members)
			{
				if (character.Region == region)
				{
					charactersInRegion.Add(character);
				}
			}

			if (charactersInRegion.Count > 0)
			{
				Console.WriteLine($"Members in {region}:");
				foreach (var character in charactersInRegion)
				{
					Console.WriteLine($"{character.Name} ({character.Race}) with {character.Weapon.Name}");
				}
			}
			else if (charactersInRegion.Count == 0)
			{
				Console.WriteLine($"No members in {region}");
			}
		}

		public override string ToString()
		{
			var result = "Fellowship of the Ring Members:\n";
			foreach (var member in _fellowshipOfTheRingMembers.Members())
			{
				result += $"{member.Name} ({member.Race}) with {member.Weapon.Name} in {member.Region}" + "\n";
			}

			return result;
		}
	}
}