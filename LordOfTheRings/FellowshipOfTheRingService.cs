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

		public void MoveMembersToRegion(List<Name> memberNames, Region region)
		{
			foreach (var name in memberNames)
			{
				MoveMemberToRegion(region, name);
			}
		}

		private void MoveMemberToRegion(Region region, Name name)
		{
			var currentCharacter = _fellowshipOfTheRingMembers.FindMember(name);

			if (currentCharacter is null)
				return;

			currentCharacter.MoveToRegion(region);

			if (region != Region.Mordor) Console.WriteLine($"{currentCharacter.Name} moved to {region}.");
			else Console.WriteLine($"{currentCharacter.Name} moved to {region} 💀.");
		}

		public void PrintMembersInRegion(Region region)
		{
			var charactersInRegion = _fellowshipOfTheRingMembers.MembersFromRegion(region).ToList();

			if (!charactersInRegion.Any())
			{
				Console.WriteLine($"No members in {region}");
				return;
			}

			Console.WriteLine($"Members in {region}:");
			foreach (var character in charactersInRegion)
			{
				Console.WriteLine($"{character.Name} ({character.Race}) with {character.Weapon.Name}");
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