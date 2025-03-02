using StatePattern.Constants;
using StatePattern.MapObjects.States;

namespace StatePattern.MapObjects.TreasureItems;

public class Poison : ITreasureItem
{
    public int Probability { get; private set; } = GameConfig.Treasure.Probability.Poison;
    public void Effect(Role role) => role.SetState(new Poisoned(role));
}