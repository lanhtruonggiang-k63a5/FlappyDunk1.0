using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


[System.Obsolete]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject EndlessGame;
    public GameObject MenuCanvas;
    public Animator slideMenu;
    void Start()
    {
        Instance = this;
        
    }
    private void Update()
    {
        if (EndlessGame.activeSelf)
        {
            if (BallBehavior.Instance.isDeath)
            {

                Score.Instance.scoreText.text = "";
                StartCoroutine(LoadMenuScene());
            }
        }
    }
    public IEnumerator LoadMenuScene()
    {
        EndlessGame.SetActive(false);
        MenuCanvas.SetActive(true);
        slideMenu.Play("CanvasSlide");
        yield return new WaitForSeconds(1f);


    }

    public void LoadEndless()
    {
        // bug: endless không hiện trên hiearchy trên hierachy dù return true;
        // loadScene có 2 tác dụng: reset gameover, fix đc lỗi trên. 

        EndlessGame.SetActive(true);
        MenuCanvas.SetActive(false);
        SceneManager.LoadScene(0);

        // Debug.Log("EndlessGame "+EndlessGame.activeInHierarchy);
        // Debug.Log("MenuCanvas "+ MenuCanvas.activeInHierarchy);
    }

}





