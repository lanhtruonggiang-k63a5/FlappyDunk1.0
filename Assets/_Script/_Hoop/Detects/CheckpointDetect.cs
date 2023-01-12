using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDetect : MonoBehaviour
{
    public GameObject hoop;
    private GameObject checker;
    private BoxCollider2D bc;
    

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("ball"))
        {
            if (!DetectCollider.IsComplete())
            {
                BallBehavior.Instance.isDeath = true;
                Debug.Log("death by not complete");
            }
            if (DetectCollider.IsReverse())
            {
                BallBehavior.Instance.isDeath = true;
                Debug.Log("death by reverse");
            }
        }
    }
    
}
