using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingAnimBack : MonoBehaviour
{
    public static WingAnimBack Instance { get; private set; }
    public enum WingState
    {
        flap,
        idle,
        chop
    }
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        anim = GetComponent<Animator>();
    }
    public void CallAnimFlap()
    {
        StartCoroutine(SetAnimFlap());
    }
    private IEnumerator SetAnimFlap()
    {
        // Debug.Log("Flapping");
        anim.SetInteger("state", (int)WingState.flap);
        yield return new WaitForSeconds(0.3f);
        anim.SetInteger("state", (int)WingState.idle);


        // anim.Play("WingFlapBack");
    }
    public void SetAnimChopWing()
    {
        // Debug.Log("Chopping");
        anim.SetInteger("state", (int)WingState.chop);

    }



}
