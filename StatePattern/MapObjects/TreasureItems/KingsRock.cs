using StatePattern.Constants;
using StatePattern.MapObjects.States;

namespace StatePattern.MapObjects.TreasureItems;

public class KingsRock : ITreasureItem
{
    public int Probability { get; private set; } = GameConfig.Treasure.Probability.KingsRock;
    public void Effect(Role role) => role.SetState(new Stockpile(role));
}