using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject EndlessGame;
    public GameObject MenuCanvas;
    void Start()
    {
        Instance = this;

    }
    private void Update()
    {
        if(BallBehavior.Instance.isDeath){
            
            Score.Instance.scoreText.text = "";
            LoadMenuScene();
        }
    }
    public void LoadMenuScene(){
        MenuCanvas.SetActive(true);
        EndlessGame.SetActive(false);
    }

    public void LoadEndless(){
        MenuCanvas.SetActive(false);
        EndlessGame.SetActive(true);

    }
} 
    
    



