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
        
        yield return new WaitForSeconds(2f);

        
        
        slideMenu.SetInteger("state",(int)MenuEnum.left2center);
        yield return new WaitForSeconds(0.7f);


    }

    public void OnCallEndless(){
        Debug.Log("click ball");
        StartCoroutine(LoadEndless());
    }
    public IEnumerator LoadEndless()
    {
        // bug: endless không hiện trên hiearchy trên hierachy dù return true;
        // loadScene có 2 tác dụng: reset gameover, fix đc lỗi trên. 

        slideMenu.SetInteger("state", (int)MenuEnum.center2right);
        yield return new WaitForSeconds(0.7f);

        
        
        Debug.Log("bruh");

        // Debug.Log("EndlessGame "+EndlessGame.activeInHierarchy);
        // Debug.Log("MenuCanvas "+ MenuCanvas.activeInHierarchy);
    }

}





