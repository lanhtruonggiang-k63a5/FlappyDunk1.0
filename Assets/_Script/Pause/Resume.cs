using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pauseButton;
   

    // Update is called once per frame
    void Update()
    {
        if (Pause.Instance.pauseState)
        {
            if (Input.GetMouseButtonDown(0))
            {
                pauseButton.SetActive(true);
                Pause.Instance.Resume();

            }
        }
    }
}
