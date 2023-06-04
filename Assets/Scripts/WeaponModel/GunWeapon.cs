using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWeapon : Weapon
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetInstanceID() != id && other.gameObject.GetComponent<IAttack>() != null)
        {
            attackSystem = stats.GetComponent<AttackSystem>();
            statsEnemy = other.GetComponent<Stats>();
            Fire();
        }
    }

    public override void Fire()
    {
        Visualization();
        attackSystem.SetDeath(death, statsEnemy);
        attackSystem.GetDamage(damageValue);
    }

    public override void Visualization()
    {
        Debug.Log("Visualization use weapon animation / particalEffect");
    }
}
