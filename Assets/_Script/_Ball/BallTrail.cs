using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrail : MonoBehaviour
{
    public static  BallTrail Instance { get; private set; }
    // Start is called before the first frame update
    public ParticleSystem x2Trail;
    public ParticleSystem x3Trail;

    [System.Obsolete]
    void Start()
    {
        Instance = this;
        x2Trail.enableEmission = false;
        x3Trail.enableEmission = false;

    }

    [System.Obsolete]
    public void OnX2Trail(){
        x2Trail.enableEmission = true;
   }

    [System.Obsolete]
    public void OnX3Trail(){
        x3Trail.enableEmission = true;
   }
}
