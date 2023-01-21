using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingSkin : MonoBehaviour
{
    public static WingSkin Instance { get; private set; }
    
    private SpriteRenderer sr;
    public Sprite normal;
    public Sprite x3;
    // Start is called before the first frame update
    void Start()
    {
        
        Instance = this;
        sr = GetComponent<SpriteRenderer>();
    }
    public void SetSpriteNormal(){
        sr.sprite = normal;
    }
    public void SetSpriteX3(){
        sr.sprite = x3;
    }
}
