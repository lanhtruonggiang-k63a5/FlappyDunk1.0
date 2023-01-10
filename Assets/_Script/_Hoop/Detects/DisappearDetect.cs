using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearDetect : MonoBehaviour
{
    private BoxCollider2D bc;
    private Animator hoopAnim;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        hoopAnim = GetComponentInParent<Animator>();
        hoopAnim.speed = 0f;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            Debug.Log("enter collider");
            if (DetectCollider.IsComplete())
            {
                hoopAnim.speed = 1f;
            }
        }
    }
}
