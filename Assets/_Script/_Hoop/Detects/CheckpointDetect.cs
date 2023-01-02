using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDetect : MonoBehaviour
{
    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!DetectCollider.Instance.IsComplete() || DetectCollider.Instance.IsReverse())
        {
            
            BallBehavior.Instance.isDeath = true;

        }

        else if (DetectCollider.Instance.IsSwish())
        {
            Debug.Log("DetectCollider.Instance.IsSwish()"+DetectCollider.Instance.IsSwish());
            Score.Instance.countSwish++;
            Score.Instance.score+=Score.Instance.countSwish;
        }
        else
        {
            Score.Instance.countSwish = 0;
            Score.Instance.score++;
        }

    }
   
    private void OnTriggerExit2D(Collider2D other)
    {
        DetectCollider.Instance.ResetList();
    }
}
