using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Pause : MonoBehaviour, IPointerDownHandler
{
    public static Pause Instance { get; private set; }
    public bool pauseState;
    
    public GameObject pauseCanvas;
    public GameObject pauseButton;

    
    
    private void Start()
    {
        Instance = this;
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        pauseState=true;
        pauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
    }
    public void Resume(){
        pauseButton.SetActive(true);
        pauseState=false;
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
   

}
