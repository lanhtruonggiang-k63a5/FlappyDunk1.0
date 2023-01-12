using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class VibratorEnable : MonoBehaviour, IPointerDownHandler
{
    private Image img;

    public Sprite enableVibraSprite;
    public Sprite disableVibraSprite;


    private void Start()
    {
        img = GetComponent<Image>();
        if (PlayerPrefs.GetInt("enableVibrator") == 1)
        {
            img.sprite = enableVibraSprite;
        }
        else
        {
            img.sprite = disableVibraSprite;
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if(PlayerPrefs.GetInt("enableVibrator") == 1){
            PlayerPrefs.SetInt("enableVibrator",0);
        }else{
            PlayerPrefs.SetInt("enableVibrator", 1);
        }
        
        SwitchSprite();
    }

    private void SwitchSprite()
    {
        if (PlayerPrefs.GetInt("enableVibrator") == 1)
        {
            img.sprite = enableVibraSprite;
        }
        else
        {
            img.sprite = disableVibraSprite;
        }
    }
    public static void CallVibra(){
        if (PlayerPrefs.GetInt("enableVibrator") == 1)
        {
            Vibrator.Vibrate();
        }
    }

}
