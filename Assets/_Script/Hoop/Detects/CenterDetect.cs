using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterDetect : MonoBehaviour
{
    private BoxCollider2D pc2D;
    // Start is called before the first frame update
    void Start()
    {
        pc2D = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        DetectCollider.Instance.listState.Add((int)EnumState.center);
        Debug.Log("collide Center");
    }
}
