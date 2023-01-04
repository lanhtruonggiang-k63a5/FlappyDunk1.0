using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreMenu : MonoBehaviour
{
    // public static ScoreMenu Instance { get; private set; }
    public Text lastScoreText;
    // private Text bestScoreText;
    
    public Text colorScore;
    private void Awake()
    {
        // Instance = this;
        lastScoreText.text = "LAST: " + PlayerPrefs.GetInt("lastScore").ToString();

        // bestScoreText = GetComponent<Text>();
        
        colorScore.text = PlayerPrefs.GetInt("bestScore").ToString();
        colorScore.color = Color.green;
        
        // bestScoreText.text = "BEST: "+ colorScore;
        // bestScoreText.text =  <color=green>bestScoreText</color>" ;
    }

}
