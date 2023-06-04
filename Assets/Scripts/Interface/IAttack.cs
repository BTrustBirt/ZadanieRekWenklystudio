using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack 
{
    public void GetDamage(int damage);
    public void SetDeath(Death death ,Stats attack);
}
