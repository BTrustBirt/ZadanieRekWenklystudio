using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Invoke("Reset", RESET_TIME);
    }

    private void Reset()
    {
        meshRenderer.material = baseMaterial;
    }
}
