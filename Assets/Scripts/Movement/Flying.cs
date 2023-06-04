using UnityEngine;

public class Flying : Movement
{
    [SerializeField]
    private ParticleSystem particleSystem;
    public override void MoveToPosition(Vector3 terageToMove)
    {
        pivotPlayer.transform.position = Vector3.Slerp(
                pivotPlayer.transform.position,
                terageToMove,
                Time.deltaTime * speed);
    }

    public override void AnimationMove()
    {
        //particleSystem.Play();
    }
}
