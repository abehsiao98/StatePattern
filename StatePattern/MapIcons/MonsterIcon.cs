using StatePattern.Constants;
using StatePattern.MapObjects;

namespace StatePattern.MapIcons;

public class MonsterIcon(MapIcon? next) : MapIcon(next)
{
    protected override bool IsMatch(MapObject? mapObject) => mapObject is Monster;
    protected override void Action(MapObject? mapObject) => Console.Write(GameConfig.Monster.Icon);
}