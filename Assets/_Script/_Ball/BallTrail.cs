using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Obsolete]
public class BallTrail : MonoBehaviour
{
    public static BallTrail Instance { get; private set; }
    // Start is called before the first frame update
    public ParticleSystem x2Trail;
    public ParticleSystem x3Trail;
    public ParticleSystem x3Smoke;

    void Start()
    {
        Instance = this;
        x2Trail.enableEmission = false;
        x3Trail.enableEmission = false;
        x3Smoke.enableEmission = false;

    }

    public void OnX2Trail()
    {
        x2Trail.enableEmission = true;
    }
    public void OffX2Trail(){
        x2Trail.enableEmission = false;

    }


    public void OnX3Trail()
    {
        x3Trail.enableEmission = true;
        x3Smoke.enableEmission = true;
    }
    public void OffX3Trail(){
        x3Trail.enableEmission = false;
        x3Smoke.enableEmission = false;
    }
}
