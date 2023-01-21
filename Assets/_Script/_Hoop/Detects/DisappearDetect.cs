using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearDetect : MonoBehaviour
{
    public static DisappearDetect Instance { get; set; }

    
    private BoxCollider2D bc;
    
    private Hoop hoopComponent;

    public GameObject hoop;

    // Start is called before the first frame update
    [Obsolete]
    private void Awake()
    {
        Instance = this;
        bc = GetComponent<BoxCollider2D>();
        hoopComponent = GetComponent<Hoop>();
    }

    [Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            if(HoopMoving.Instance != null){
                HoopMoving.Instance.SetIsMoving(false);
                Debug.Log("not moving");
            }
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
        hoopComponent.SetDisappearState();
        yield return new WaitForSeconds(0.5f);
        hoop.SetActive(false);
    }
    private void OnEnable()
    {
        //Debug to console
        //anim run on animator
        //but still not show on game 
        hoopComponent.SetDefaultState();
    }


}
