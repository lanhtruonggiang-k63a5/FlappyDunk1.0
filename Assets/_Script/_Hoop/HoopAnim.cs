using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopAnim : MonoBehaviour
{
    public Animator hoopAnim;
    public void SetDisappearState()
    {
        hoopAnim.SetInteger("state", (int)HoopEnum.disappearState);
    }
    public void SetDefaultState()
    {
        Debug.Log("hoopAnim : "+hoopAnim.gameObject.activeSelf);
        hoopAnim.SetInteger("state", (int)HoopEnum.defaultState);
    }

}
