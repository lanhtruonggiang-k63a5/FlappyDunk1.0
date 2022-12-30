using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDetect : MonoBehaviour
{
    private PolygonCollider2D pc2D;
    // Start is called before the first frame update
    void Start()
    {
        pc2D = GetComponent<PolygonCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        DetectCollider.Instance.listState.Add((int)EnumState.edge);
        Debug.Log("collide left");
    }
}
