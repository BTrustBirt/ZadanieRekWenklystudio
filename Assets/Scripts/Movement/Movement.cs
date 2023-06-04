using UnityEngine;
/// <summary>
/// The movement system should place a script for the child under 
/// the main character object. It is necessary to add a motion detection 
/// system and separate it for cases where we want to use the movement 
/// system for either an AI-controlled character or a player.
/// The script is already prepared for this separation
/// </summary>
public abstract class Movement : MonoBehaviour
{
    [SerializeField]
    protected Transform pivotPlayer;

    [SerializeField]
    protected float speed = 0.5f;

    private Vector3 moveTarget;

    protected void Move(Vector3 move)
    {
        moveTarget = move;
    }

    private void Update()
    {
        if (pivotPlayer.transform.position != moveTarget)
        {
            MoveToPosition(moveTarget);
        }
    }

    public virtual void MoveToPosition(Vector3 terageToMove)
    {
        pivotPlayer.transform.position = Vector3.MoveTowards(
                pivotPlayer.transform.position,
                terageToMove,
                Time.deltaTime * speed);
    }

    public abstract void AnimationMove();
}
