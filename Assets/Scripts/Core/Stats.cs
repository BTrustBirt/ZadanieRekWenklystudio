using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script containing character parameters and functions that accept values 
/// to perform actions and change character statistics. 
/// The script should include all references to audio, animator, and other components,
/// as well as functions that modify parameters in those components.
/// </summary>

public class Stats : MonoBehaviour
{
    [field: SerializeField]
    public MeshRenderer meshRenderer { get; private set; }

    private int health;

    public int Health
    {
        get { return health; }
        set
        {
            health = value;
            if (Health <= 0 && data != null)
            {
                RunDeath();
            }
        }
    }

    protected DamageHelper<Death> data;

    [SerializeField]
    private int beginHealth;

    private Material baseMaterial;

    const float RESET_TIME = 2f;

    private void Start()
    {
        Health = beginHealth;
        meshRenderer = GetComponent<MeshRenderer>();
        baseMaterial = meshRenderer.material;
    }

    protected void Damage(int damage)
    {
        Health -= damage;
    }

    protected void RunDeath()
    {
        data.RunDeathVisualization();
    }
}
