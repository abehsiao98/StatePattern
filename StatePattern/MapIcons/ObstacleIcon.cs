using StatePattern.Constants;
using StatePattern.MapObjects;

namespace StatePattern.MapIcons;

public class ObstacleIcon(MapIcon? next) : MapIcon(next)
{
    protected override bool IsMatch(MapObject? mapObject) => mapObject is Obstacle;
    protected override void Action(MapObject? mapObject) => Console.Write(GameConfig.Obstacle.Icon);
}