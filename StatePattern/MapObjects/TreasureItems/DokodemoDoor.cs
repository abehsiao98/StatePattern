using StatePattern.Constants;
using StatePattern.MapObjects.States;

namespace StatePattern.MapObjects.TreasureItems;

public class DokodemoDoor : ITreasureItem
{
    public int Probability { get; private set; } = GameConfig.Treasure.Probability.DokodemoDoor;
    public void Effect(Role role) => role.SetState(new Teleport(role));
}