using StatePattern.Constants;
using StatePattern.MapObjects.States;

namespace StatePattern.MapObjects.TreasureItems;

public class DevilFruit : ITreasureItem
{
    public int Probability { get; private set; } = GameConfig.Treasure.Probability.DevilFruit;
    public void Effect(Role role) => role.SetState(new Orderless(role));
}