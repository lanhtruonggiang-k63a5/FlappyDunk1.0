using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }
    //
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
    //
    public float volume;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        
    }
    

    public void PlayBounce(){
        bounce.volume = volume;
        bounce.Play();
    }
    public void PlayBuildUp()
    {
        buildUp.volume = volume;
        buildUp.Play();
    }
    public void PlayCrash()
    {
        crash.volume = volume;
        crash.Play();
    }
    public void PlayFlap()
    {
        flap.volume = volume;
        flap.Play();
    }
    public void PlayNewBestScore()
    {
        newBestScore.volume = volume;
        newBestScore.Play();
    }
    public void PlayPass()
    {
        pass.volume = volume;
        pass.Play();
    }
    public void PlayWhistle()
    {
        whistle.volume = volume;
        whistle.Play();
    }
    public void PlayWrong()
    {
        wrong.volume = volume;
        wrong.Play();
    }
    public void PlayX2()
    {
        x2.volume = volume;
        x2.Play();
    }
    public void PlayX3()
    {
        x3.volume = volume;
        x3.Play();

    }
    public void PlayX4()
    {
        x4.volume = volume;
        x4.Play();
    }
  
}
