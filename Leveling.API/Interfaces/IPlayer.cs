namespace Leveling.Leveling.API.Interfaces;

public interface IPlayer
{
    public int    Id    {get; init;}
    public string Name  {get;  set;}
    public int    Xp    {get;  set;}
    public int    Level {get;  set;}
}