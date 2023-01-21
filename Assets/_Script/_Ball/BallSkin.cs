using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallSkin : MonoBehaviour
{
    public static BallSkin Instance { get; private set; }
    private SpriteRenderer sr;

    public Sprite normal;
    public Sprite x3;

    void Start()
    {
        Instance = this;
        sr = GetComponent<SpriteRenderer>();
        SetSkinNormal();
    }

    
    public void SetSkinNormal(){
        sr.sprite = normal;
    }
    public void SetSkinX3(){
        sr.sprite = x3;
    }
}
