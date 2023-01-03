using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboveDetect : MonoBehaviour
{
    private BoxCollider2D pc2D;
    // Start is called before the first frame update
    void Start()
    {
        pc2D = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        DetectCollider.listState.Add((int)EnumState.above);
    }
}
