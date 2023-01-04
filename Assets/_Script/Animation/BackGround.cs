using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public static BackGround Instance { get; private set; }
    public Animator anim;

    void Start()
    {
        Instance = this;
        anim = GetComponent<Animator>();
        anim.speed = 0f;
    }

}
