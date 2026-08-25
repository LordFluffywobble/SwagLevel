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
    public void CreateAPlayer()
    {
        var controller  = new PlayerController();
        var player1     = new Player(1, "KITT", 5, 2);

        var result      = controller.CreatePlayer(player1);
        var okResult    = Assert.IsType<OkObjectResult>(result);
        
        var returnedPlayer = Assert.IsType<Player>(okResult.Value);

        Assert.Equal("KATT", returnedPlayer.Name);
        
    }

}
