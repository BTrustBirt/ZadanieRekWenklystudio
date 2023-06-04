using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketWeapo : Weapon
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IAttack>() != null)
        {
            attackSystem = gameObject.GetComponent<AttackSystem>();
            statsEnemy = other.GetComponent<Stats>();
            Fire();
        }
    }

    public override void Fire()
    {
        Visualization();
        attackSystem.SetDeath(death,statsEnemy);
        attackSystem.GetDamage(damageValue);
    }

    public override void Visualization()
    {
        Debug.Log("Visualization use weapon animation / particalEffect");
    }
}
