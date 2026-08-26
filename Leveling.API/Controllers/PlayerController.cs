namespace Leveling.Leveling.API.Controllers;

using Microsoft.AspNetCore.Mvc;
using Leveling.API.Classes;


[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    private static readonly List<Player> _playerList = new List<Player>();

    [HttpPost("createplayer")]
    public IActionResult CreatePlayer([FromBody] Player newPlayer)
    {
        if (newPlayer == null || string.IsNullOrEmpty(newPlayer.Name))
        {
            return BadRequest("Player needs a valid name");
        }
        
        _playerList.Add(newPlayer);

        return CreatedAtAction(nameof(GetPlayerDetails), new {id = newPlayer.Id}, newPlayer);
    }
    
    [HttpGet("allplayers")]
    public IActionResult GetAllPlayers()
    {
        return Ok(_playerList);
    }  
    


    [HttpGet("details")]
    public IActionResult GetPlayerDetails()
    {
        var _player = new Player(1, "KITT", 1, 1);
        return Ok(_player);
    }   
    

    [HttpGet("player/{id}")]
    public IActionResult GetPlayerById(int id)
    {
        var player = _playerList.FirstOrDefault(p => p.Id == id);
        if (player == null)
        {
            return NotFound("No players with that Id");
        }
        return Ok(player);
    }
    
    [HttpPatch("{id}addplayerxp")]
    public IActionResult LevelUp(int id, [FromBody] int amount)
    {
        Player player = GetPlayerById(id);
        if (player == null)
        {
            return NotFound("No player with that Id {id}");
        }
    
        var xpManager = new Xp();
        xpManager.AddXp(player, amount);
        
        return Ok(player);
    }
}


