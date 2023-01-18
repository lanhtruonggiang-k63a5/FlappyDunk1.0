using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }
    // Start is called before the first frame update
    public int score;
    public int countSwish;
    public int bestScore;
    public int lastScore;
    public Text scoreText;

   
    void Start()
    {
        Instance = this;
        score = 0;
        scoreText = GetComponent<Text>();
        countSwish = 1;
        // PlayerPrefs.SetInt("bestScore", 0);
    }
    void Update()
    {
        LoadBestScore();
        scoreText.text = score.ToString();
        LoadLastScore();

    }
    void LoadBestScore()
    {
        if (score > PlayerPrefs.GetInt("bestScore"))
        {
            PlayerPrefs.SetInt("bestScore", score);
        }
    }
    void LoadLastScore()
    {
        lastScore = score;
        PlayerPrefs.SetInt("lastScore", lastScore);
    }

    public void Plus1()
    {
        countSwish = 1;
        
        score += countSwish;
    }

    [System.Obsolete]
    public void PlusSwish()
    {
        countSwish++;
        if (countSwish == 2)
        {
            HoopParticle.Instance.OnX2();
            BallTrail.Instance.OnX2Trail();
        }
        if (countSwish == 3)
        {
            HoopParticle.Instance.OnX3();
            BallTrail.Instance.OnX3Trail();
        }
        score += countSwish;
    }
}

