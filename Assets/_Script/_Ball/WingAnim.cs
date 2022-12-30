using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingAnim : MonoBehaviour
{
    public static WingAnim Instance { get; private set; }
    public enum WingState
    {
        flap,
        chop
    }
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        anim = GetComponent<Animator>();
    }

    public void SetAnimFlap(){
        anim.SetInteger("state",(int)WingState.flap);
    }
    public void SetAnimChopWing()
    {
        Debug.Log("Chopping");
        anim.SetInteger("state", (int)WingState.chop);
    }
    

}
