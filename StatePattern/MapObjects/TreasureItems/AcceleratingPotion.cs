using StatePattern.Constants;
using StatePattern.MapObjects.States;

namespace StatePattern.MapObjects.TreasureItems;

public class AcceleratingPotion : ITreasureItem
{
    public int Probability { get; private set; } = GameConfig.Treasure.Probability.AcceleratingPotion;
    public void Effect(Role role) => role.SetState(new Accelerated(role));
}