using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The DamageHelper class is a generic class used for handling 
/// damage-related operations. It contains a Data field that holds
/// the associated data, which should inherit from the Death class. 
/// The class provides methods to run 
/// the death visualization and retrieve the character's stats.
/// </summary>

public class DamageHelper<T> where T : Death
{
    public T Data;

    public DamageHelper(T Data)
    {
        this.Data = Data;
    }

    // Run the death visualization for the character
    public void RunDeathVisualization()
    {
        Data.Die();
    }

    // Get the stats of the character
    public void GetStats(Stats stats)
    {
        Data.OnStats(stats);
    }
}
