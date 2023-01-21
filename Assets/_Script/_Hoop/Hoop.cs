using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop : MonoBehaviour
{
    private Animator hoopAnim;
    
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
    }
    
    public void SetDisappearState(){
        hoopAnim.SetInteger("state", (int)HoopEnum.disappearState);
    }
    public void SetDefaultState()
    {
        hoopAnim.SetInteger("state", (int)HoopEnum.defaultState);
    }

}
