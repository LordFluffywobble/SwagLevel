namespace Leveling.Leveling.API.Classes;

using Leveling.API.Classes;
using Leveling.API.Controllers;

public class Xp
{
    public void AddXp(Player player, int amount)
    {
        player.Xp += amount;
    }
}