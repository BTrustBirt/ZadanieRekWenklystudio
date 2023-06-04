using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : Death
{
    public Material material;

    private MeshRenderer meshRenderer;
    public override void Die()
    {
        meshRenderer.material = material;
    }

    protected override void Initialization()
    {
        meshRenderer = stats.meshRenderer;
    }
}
