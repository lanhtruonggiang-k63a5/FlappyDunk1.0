using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBelow : MonoBehaviour
{
    private PolygonCollider2D pc2D;
    // Start is called before the first frame update
    void Start()
    {
        pc2D = GetComponent<PolygonCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        DetectCollider.listState.Add((int)EnumState.edge);
        // HoopMoving.Instance.isTransform = false;
        // BackGround.Instance.anim.speed = 0f;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        // HoopMoving.Instance.isTransform = true;
        // BackGround.Instance.anim.speed = 1f;
    }
}
