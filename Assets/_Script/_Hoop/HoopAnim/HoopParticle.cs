using UnityEngine;

public class HoopParticle : MonoBehaviour
{
    public static HoopParticle Instance { get; private set; }
    public ParticleSystem x2Blast;
    public ParticleSystem x3Blast;

    public ParticleSystem x2Smoke;
    public ParticleSystem x3Smoke;

    public ParticleSystem swishStar;


    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        Instance = this;
        x2Blast.enableEmission = false;
        x3Blast.enableEmission = false;
        x2Smoke.enableEmission = false;
        x3Smoke.enableEmission = false;
        swishStar.enableEmission = false;
    }

    [System.Obsolete]
    public void OnX2()
    {
        swishStar.enableEmission = true;
        x2Blast.enableEmission = true;
        x2Smoke.enableEmission = true;

    }

    [System.Obsolete]
    public void OnX3()
    {
        swishStar.enableEmission = true;
        x3Blast.enableEmission = true;
        x3Smoke.enableEmission = true;
    }
}
