using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Death: MonoBehaviour
{
    protected Stats stats;

    public void OnStats(Stats stats)
    {
        this.stats = stats;
        Initialization();
    }

    protected abstract void Initialization();
   
    public abstract void Die(); 
    
}
