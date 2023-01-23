using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingSplit : MonoBehaviour
{
    public static  WingSplit Instance { get; private set; }
    public GameObject wingFront;
    public GameObject wingBack;

    public GameObject ball;
    
    private void Start()
    {
        Instance = this;
        wingFront.transform.parent = ball.transform;
        wingBack.transform.parent = ball.transform;

    }
    public void SetTransformMenu( Vector2 currentPos){
        GameObject currentBall = new GameObject();
        currentBall.transform.position = currentPos;

        wingFront.transform.SetParent(currentBall.transform,true);
        wingBack.transform.SetParent(currentBall.transform,true);

    }




    
}
