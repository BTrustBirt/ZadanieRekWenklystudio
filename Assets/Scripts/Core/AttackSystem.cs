using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
