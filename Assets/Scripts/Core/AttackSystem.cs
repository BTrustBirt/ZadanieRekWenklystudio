using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The script inherits from "Stats" and serves the purpose of communication 
/// and receiving damage and other functions from attackers.
/// </summary>

public class AttackSystem : Stats,IAttack
{
    public void GetDamage(int damage)
    {
        Damage(damage);
    }

    public void SetDeath(Death death,Stats attack)
    {
        data = new DamageHelper<Death>(death);
        data.GetStats(attack);
    }
}
