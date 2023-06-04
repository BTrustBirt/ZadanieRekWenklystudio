using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallk : Movement
{
    [SerializeField]
    private Animation animation;

    public override void MoveToPosition(Vector3 terageToMove)
    {
        base.MoveToPosition(terageToMove);
        AnimationMove();
    }

    public override void AnimationMove()
    {
        //animation.Play();
    }
}
