using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject DeathCanvas;
    void Start()
    {
        Instance = this;

    }
    

    
    private void Update()
    {
        if(BallBehavior.Instance.isDeath){
            DeathCanvas.SetActive(true);
            StartCoroutine(LoadMenuScene());
        }
    }
    private IEnumerator LoadMenuScene(){

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
    }
 
} 
    
    



