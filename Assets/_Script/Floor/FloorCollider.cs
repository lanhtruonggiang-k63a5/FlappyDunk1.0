using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollider : MonoBehaviour
{
    private BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("lose");
    }
}
