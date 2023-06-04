using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHelper<T> where T : Death
{
    public T Data;

    public DamageHelper(T Data)
    {
        this.Data = Data;
    }
    public void RunDeathVisualization()
    {
        Data.Die();
    }

    public void GetStats(Stats stats)
    {
        Data.OnStats(stats);
    }
}
