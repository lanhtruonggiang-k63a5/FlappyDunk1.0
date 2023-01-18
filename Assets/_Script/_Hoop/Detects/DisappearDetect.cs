using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearDetect : MonoBehaviour
{
    public static DisappearDetect Instance { get; set; }

    
    private BoxCollider2D bc;
    private Animator hoopAnim;
    
    

    public GameObject hoop;

    // Start is called before the first frame update
    [Obsolete]
    private void Awake()
    {
        Instance = this;
        bc = GetComponent<BoxCollider2D>();
        hoopAnim = GetComponentInParent<Animator>();
        

    }

    [Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            if (!DetectCollider.IsComplete())
            {
                BallBehavior.Instance.isDeath = true;
                Debug.Log("death by not complete");
            }
            else if (DetectCollider.IsReverse())
            {
                BallBehavior.Instance.isDeath = true;
                Debug.Log("death by reverse");
            }

            else if (DetectCollider.IsSwish())
            {
                HoopSpawner.spawnNext = true;
                Score.Instance.PlusSwish();
                DetectCollider.ResetList();
                StartCoroutine(DisappearObject());
            }
            else
            {
                HoopSpawner.spawnNext = true;
                Score.Instance.Plus1();
                DetectCollider.ResetList();
                StartCoroutine(DisappearObject());
            }
            
        }

    }

    public IEnumerator DisappearObject()
    {
        hoopAnim.SetInteger("state", (int)HoopEnum.disappearState);
        yield return new WaitForSeconds(0.5f);
        hoop.SetActive(false);
    }
    private void OnEnable()
    {
        //Debug to console
        //anim run on animator
        //but still not show on game 
        this.hoopAnim.SetInteger("state", (int)HoopEnum.defaultState);
    }

}
