using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    public AudioSource bounce;
    public AudioSource buildUp;
    public AudioSource crash;
    public AudioSource flap;
    public AudioSource newBestScore;
    public AudioSource pass;
    public AudioSource whistle;
    public AudioSource wrong;
    public AudioSource x2;
    public AudioSource x3;
    public AudioSource x4;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

    }

    public void PlayBounce(){
        bounce.Play();
    }
    public void PlayBuildUp()
    {
        buildUp.Play();
    }
    public void PlayCrash()
    {
        crash.Play();
    }
    public void PlayFlap()
    {
        flap.Play();
    }
    public void PlayNewBestScore()
    {
        newBestScore.Play();
    }
    public void PlayPass()
    {
        pass.Play();
    }
    public void PlayWhistle()
    {
        whistle.Play();
    }
    public void PlayWrong()
    {
        wrong.Play();
    }
    public void PlayX2()
    {
        x2.Play();
    }
    public void PlayX3()
    {
        x3.Play();
    }
    public void PlayX4()
    {
        x4.Play();
    }
  
}
