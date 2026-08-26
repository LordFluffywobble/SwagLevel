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
        
    }
}