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
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        Debug.Log("collide Surround");
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("Swish || Reverse || Complete");
        Debug.Log(DetectCollider.Instance.IsSwish());
        Debug.Log(DetectCollider.Instance.IsComplete());
        Debug.Log(DetectCollider.Instance.IsReverse());

        DetectCollider.Instance.ResetList();
        
        Debug.Log("exit Surround");
    }
}
