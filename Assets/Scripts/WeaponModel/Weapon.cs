using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public Death death;

    protected AttackSystem attackSystem;

    protected Stats statsEnemy;

    [SerializeField]
    protected int damageValue;

    private void Start()
    {
        death = gameObject.GetComponent<Death>();    
    }

    public abstract void Fire();
    public abstract void Visualization();
}
