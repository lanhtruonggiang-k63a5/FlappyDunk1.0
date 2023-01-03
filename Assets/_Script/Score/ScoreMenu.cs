using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreMenu : MonoBehaviour
{
    public static  ScoreMenu Instance { get; private set; }

    public Text BestScoreText;
    public Text LastScoreText;

    

    void Start()
    {
        Instance = this;
        PlayerPrefs.SetInt("bestScore", Score.Instance.highScore);
        PlayerPrefs.SetInt("lastScore", Score.Instance.lastScore);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
