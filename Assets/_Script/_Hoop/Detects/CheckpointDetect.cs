using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDetect : MonoBehaviour
{
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
            
                Debug.Log(" ball enter");
                if (!DetectCollider.IsComplete())
                {
                    BallBehavior.Instance.isDeath = true;
                }
                if (DetectCollider.IsReverse())
                {
                    BallBehavior.Instance.isDeath = true;
                }

                else if (DetectCollider.IsSwish())
                {
                    Score.Instance.countSwish++;
                    Score.Instance.score += Score.Instance.countSwish;
                }
                else
                {
                    Score.Instance.countSwish = 1;
                    Score.Instance.score++;
                }
                
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            
            Debug.Log("ball Exit");
            DetectCollider.ResetList();

        }
    }
}
