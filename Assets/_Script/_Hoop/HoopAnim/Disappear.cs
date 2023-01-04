using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public static  Disappear Instance { get; private set; }
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        anim = GetComponent<Animator>();
    }

    public void TurnOnAnim(){
        anim.speed = 1f;
    }
    public void TurnOffAnim(){
        anim.speed = 0f;
    }
    
}
