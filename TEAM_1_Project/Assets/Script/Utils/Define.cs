using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum UnitCamp
    {
        playerUnit,
        enemyUnit
    }
    public enum Effect
    {
        seed,
        boom,
        stealer,
        stealerToSeed,
        stealerToBoom
    }
    public enum SeedState
    {
        nothing,
        skill
    }
    public enum BoomState
    {
        nothing,
        skill
    }
    public enum StealerState
    {
        nothing,
        attack,
        stealSeed,
        stealBoom
    }
}
