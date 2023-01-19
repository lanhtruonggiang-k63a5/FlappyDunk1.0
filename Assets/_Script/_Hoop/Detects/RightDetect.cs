using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDetect : MonoBehaviour
{
    private BoxCollider2D pc2D;
    // Start is called before the first frame update
    void Start()
    {
        pc2D = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        DetectCollider.listState.Add((int)EnumState.edge);
        BallBehavior.Instance.CallBallStop();
        // HoopMoving.Instance.isTransform = false;
        // BackGround.Instance.anim.speed = 0f;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        // HoopMoving.Instance.isTransform = true;
        // BackGround.Instance.anim.speed = 1f;
    }
    
}
