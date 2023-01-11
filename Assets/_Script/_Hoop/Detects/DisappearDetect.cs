using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearDetect : MonoBehaviour
{   
    public static  DisappearDetect Instance { get; set; }
    public GameObject hoop;
    private BoxCollider2D bc;
    private Animator hoopAnim;

    public bool activeDefaultAnim;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        bc = GetComponent<BoxCollider2D>();
        hoopAnim = GetComponentInParent<Animator>();
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        if (hoop.activeSelf == true && !activeDefaultAnim)
        {
            hoopAnim.SetInteger("state", (int)HoopEnum.defaultState);
            activeDefaultAnim=true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            StartCoroutine(DisappearObject());
        }
    }
    public IEnumerator DisappearObject(){
        if (DetectCollider.IsComplete())
        {
            hoopAnim.SetInteger("state",(int)HoopEnum.disappearState);
            yield return new WaitForSeconds(1f);
            activeDefaultAnim = false;
            hoop.SetActive(false);
        }
        
    }
}
