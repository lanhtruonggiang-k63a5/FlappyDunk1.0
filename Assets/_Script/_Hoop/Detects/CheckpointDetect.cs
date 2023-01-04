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

            // Debug.Log(" ball enter");
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

            else if (DetectCollider.IsSwish())
            {
                Score.Instance.PlusSwish();
                // Score.Instance.countSwish++;
                // Score.Instance.score += Score.Instance.countSwish;
            }
            else
            {
                Score.Instance.Plus1();
                // Score.Instance.countSwish = 1;
                // Score.Instance.score++;
            }
            // Debug.Log("ball Exit");
            DetectCollider.ResetList();
            Disappear.Instance.TurnOnAnim();

        }
    }
    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("ball"))
    //     {
    //         Debug.Log("ball Exit");
    //         DetectCollider.ResetList();


    //     }
    // }


    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("ball"))
    //     {
    //         Debug.Log("enter");
    //     }
    // }
    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("ball"))
    //     {
    //         Debug.Log("leave");
    //     }
    // }

    // private void OnTriggerStay2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag("ball"))
    //     {
    //         Debug.Log("stay");
    //     }
    // }
}
