using StatePattern.Constants;
using StatePattern.MapObjects.States;

namespace StatePattern.MapObjects.TreasureItems;

public class SuperStar : ITreasureItem
{
    public int Probability { get; private set; } = GameConfig.Treasure.Probability.SuperStar;
    public void Effect(Role role) => role.SetState(new Invincible(role));
}