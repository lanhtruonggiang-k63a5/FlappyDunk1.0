using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SoundEnable : MonoBehaviour, IPointerDownHandler
{

    private Image img;
    public Sprite enableSoundSprite;
    public Sprite disableSoundSprite;

    private void Start()
    {
        img = GetComponent<Image>();
        if (PlayerPrefs.GetInt("enableSound") == 1)
        {
            img.sprite = enableSoundSprite;
            SoundManager.Instance.volume = 1f;
        }
        else
        {
            img.sprite = disableSoundSprite;
            SoundManager.Instance.volume = 0f;
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (PlayerPrefs.GetInt("enableSound") == 1)
        {
            PlayerPrefs.SetInt("enableSound", 0);
        }
        else
        {
            PlayerPrefs.SetInt("enableSound", 1);
        }
        SwitchSprite();
        CallMuteUnmute();
        Debug.Log("volume "+ SoundManager.Instance.volume);
    }
    private void SwitchSprite()
    {
        if (PlayerPrefs.GetInt("enableSound") == 1)
        {
            img.sprite = enableSoundSprite;
        }
        else
        {
            img.sprite = disableSoundSprite;
        }
    }
    public static void CallMuteUnmute()
    {
        if (PlayerPrefs.GetInt("enableSound") == 1)
        {
            SoundManager.Instance.volume = 1f;
        }
        else
        {
            SoundManager.Instance.volume = 0f;
        }
    }


}
