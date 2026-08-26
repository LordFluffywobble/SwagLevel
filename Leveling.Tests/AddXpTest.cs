namespace Leveling.Tests;

using Leveling.API.Classes;
using Leveling.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

public class AddXpTests
{
    [Fact]
    public void AddSomeXp()
    {
        var xpManager   = new Xp();
        var player1     = new Player(1, "KATT", 0, 1);

        xpManager.AddXp(player1, 5);

        Assert.Equal(5, player1.Xp);
        Assert.Equal(1, player1.Level);
    }

    [Fact]
    public void AddLevel()
    {
        var xpManager   = new Xp();
        var player1     = new Player(1, "KATT", 0, 1);

        xpManager.AddXp(player1, 25);

        Assert.Equal(1, player1.Id);
        Assert.Equal("KITT", player1.Name);
        Assert.Equal(25, player1.Xp);
        Assert.Equal(2, player1.Level);
    }
}