namespace Leveling.Leveling.API.Classes;

using Leveling.API.Interfaces;

public class Player : IPlayer
{
    public int    Id    {get; init;} 
    public string Name  {get; set ;}
    public int    Xp    {get; set ;}
    public int    Level {get; set ;}

    public Player(int id, string name, int xp, int level)
    {
        Id      = id;
        Name    = name;
        Xp      = xp;
        Level   = level;
    }
}