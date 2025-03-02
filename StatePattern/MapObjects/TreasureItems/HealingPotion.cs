using StatePattern.Constants;
using StatePattern.MapObjects.States;

namespace StatePattern.MapObjects.TreasureItems;

public class HealingPotion : ITreasureItem
{
    public int Probability { get; private set; } = GameConfig.Treasure.Probability.HealingPotion;
    public void Effect(Role role) => role.SetState(new Healing(role));
}