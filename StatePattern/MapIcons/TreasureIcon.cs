using StatePattern.Constants;
using StatePattern.MapObjects;

namespace StatePattern.MapIcons;

public class TreasureIcon(MapIcon? next) : MapIcon(next)
{
    protected override bool IsMatch(MapObject? mapObject) => mapObject is Treasure;
    protected override void Action(MapObject? mapObject) => Console.Write(GameConfig.Treasure.Icon);
}