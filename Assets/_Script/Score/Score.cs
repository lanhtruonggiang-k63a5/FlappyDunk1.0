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
    public int highScore;
    public int lastScore;

    public Text scoreText;

    void Start()
    {
        Instance = this;
        score = 0;
        scoreText = GetComponent<Text>();
        countSwish=1;
    }

    void Update()
    {

        LoadBestScore();
        scoreText.text = score.ToString();

    }
    void LoadBestScore()
    {
        if (score > highScore)
        {
            highScore = score;
        }


    }
}
    
