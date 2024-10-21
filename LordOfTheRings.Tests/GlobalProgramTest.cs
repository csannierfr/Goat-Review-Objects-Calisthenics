using System.Threading.Tasks;
using LordOfTheRings.App;
using Xunit;

namespace LordOfTheRings.Tests;

public sealed class GlobalProgramTest
{
	[Fact]
	public async Task Should_Retrieve_Initial_Result()
	{
		var stringWriter = new StringWriter();
		Console.SetOut(stringWriter);
		FellowshipOfTheRingApp.Run();
		var output = stringWriter.ToString();
		Console.SetOut(Console.Out);
		await Verify(output);
	}
}