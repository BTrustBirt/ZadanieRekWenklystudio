using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class ExplosioDeath : Death
{
    public Material material;

    private MeshRenderer meshRenderer;

    public override void Die()
    {
        meshRenderer.material = material;
    }

    protected override void Initialization()
    {
        meshRenderer = stats.meshRenderer ;
    }
}
