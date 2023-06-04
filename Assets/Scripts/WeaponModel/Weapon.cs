using UnityEngine;

/// <summary>
/// The base script for weapons, the prefab, must include a script 
/// for determining death when using that weapon. Currently,
/// there may be only one type of death for a specific weapon, 
/// but additional variations can be easily added if needed.
/// The prefab should be placed under the enemy player object,
/// and all fields must be filled in.
/// Adding new weapons does not affect the base scripts,
/// but it is necessary to follow the pattern used in this scrip
/// </summary>

public abstract class Weapon : MonoBehaviour
{
    public Death death;

    [SerializeField]
    protected Stats stats;

    protected AttackSystem attackSystem;

    protected Stats statsEnemy;

    protected int id;

    [SerializeField]
    protected int damageValue;

    private void Start()
    {
        death = gameObject.GetComponent<Death>();
        if (stats != null)
        {
            id = stats.gameObject.GetInstanceID();
        }
        else
        {
            Debug.LogError($"Stats {stats} not can't be null !!!");
        }
    }

    public abstract void Fire();
    public abstract void Visualization();
}
