using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearDetect : MonoBehaviour
{
    public static DisappearDetect Instance { get; set; }
    
    private BoxCollider2D bc;
    private Animator hoopAnim;

    
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        bc = GetComponent<BoxCollider2D>();
        hoopAnim = GetComponentInParent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
    
            StartCoroutine(DisappearObject());
        }
    }
    public IEnumerator DisappearObject()
    {
        if (DetectCollider.IsComplete())
        {
            hoopAnim.SetInteger("state", (int)HoopEnum.disappearState);
            yield return new WaitForSeconds(1f);
        }

    }
    private void OnEnable()
    {
        //Debug to console
        //anim run on animator
        //but still not show on game 
        Debug.Log("enable -> default state");
        this.hoopAnim.SetInteger("state", (int)HoopEnum.defaultState);
    }

}
