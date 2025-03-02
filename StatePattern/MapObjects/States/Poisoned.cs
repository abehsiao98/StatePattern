﻿using StatePattern.Constants;

namespace StatePattern.MapObjects.States;

public class Poisoned(Role role) : State(role)
{
    public override void Action()
    {
        Role.ReduceHp(GameConfig.State.Effect.PoisonedDamage);
        base.Action();
    }
    public override void EntryState() => Role.SetState(this);
    protected override void ExitState()
    {
        if (IsTakeDamage)
            new Invincible(Role).EntryState();
        else
            new Normal(Role).EntryState();
    }
    protected override bool IsExitState() => Round > GameConfig.State.DurationRound.Poisoned || IsTakeDamage;
}