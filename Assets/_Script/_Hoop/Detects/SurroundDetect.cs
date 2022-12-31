using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurroundDetect : MonoBehaviour
{
    private BoxCollider2D pc2D;
    // Start is called before the first frame update
    void Start()
    {
        pc2D = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("collide Surround");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        // Debug.Log("Swish || Reverse || Complete");
        // Debug.Log(DetectCollider.Instance.IsSwish());
        // Debug.Log(DetectCollider.Instance.IsComplete());
        // Debug.Log(DetectCollider.Instance.IsReverse());
        // Debug.Log("exit Surround");
        DetectCollider.Instance.ResetList();

    }
}
