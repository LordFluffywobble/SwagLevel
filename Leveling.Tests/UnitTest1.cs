namespace Leveling.Tests;

using Leveling.API.Classes;
using Xunit;
using Xunit.Abstractions;

public class PlayerTests
{
    [Fact]
    public void Test1()
    {
        var player1 = new Player(1, "KITT", 1, 1);
    }
}
