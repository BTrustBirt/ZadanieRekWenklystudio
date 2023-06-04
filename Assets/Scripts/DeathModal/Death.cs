using UnityEngine;

/// <summary>
/// The Death class is an abstract class that inherits from MonoBehaviour and serves as a base
/// for character death-related functionality. 
/// It includes a protected stats field of type Stats to store the character's statistics.
/// The OnStats method is used to pass the character's stats and triggers the Initialization method.
/// </summary>

public abstract class Death: MonoBehaviour
{
    protected Stats stats;

    // Method to pass the character's stats
    public void OnStats(Stats stats)
    {
        this.stats = stats;
        Initialization();
    }

    protected abstract void Initialization();
   
    public abstract void Die(); 
    
}
