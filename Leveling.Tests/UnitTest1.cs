namespace Leveling.Tests;

using System.Security.Cryptography.X509Certificates;
using Leveling.API.Classes;
using Leveling.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Xunit.Abstractions;



public class PlayerTests
{
    [Fact]
    public void CreateAPlayerName()
    {
        var controller      = new PlayerController();
        var player1         = new Player(1, "KITT", 5, 2);

        var result          = controller.CreatePlayer(player1);
        var createdResult   = Assert.IsType<CreatedAtActionResult>(result);
        
        var returnedPlayer  = Assert.IsType<Player>(createdResult.Value);

        Assert.Equal("KITT", returnedPlayer.Name);
    }

    [Fact]
    public void CreateAPlayerId()
    {
        var controller      = new PlayerController();
        var player1         = new Player(1, "KITT", 5, 2);

        var result          = controller.CreatePlayer(player1);
        var createdResult   = Assert.IsType<CreatedAtActionResult>(result);
        var returnedPlayer  = Assert.IsType<Player>(createdResult.Value);

        Assert.Equal(1, returnedPlayer.Id);
    }
}
