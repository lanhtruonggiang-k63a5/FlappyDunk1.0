using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class DetectCollider : MonoBehaviour
{
    // public static DetectCollider Instance { get; private set; }
    public static List<int> listState;
    void Start()
    {
        // Instance = this;
        listState = new List<int>();
    }
    
    public static bool IsSwish()
    {
        if (listState.Contains((int)EnumState.edge))
        {
            return false;
        }
        return true;
    }
    public static bool IsReverse()
    {
        int indexAbove = listState.LastIndexOf((int)EnumState.above);
        int indexCenter = listState.LastIndexOf((int)EnumState.center);
        int indexBelow = listState.LastIndexOf((int)EnumState.below);
        if (indexBelow < indexCenter ){
            Debug.Log("below:"+indexBelow+"center:"+indexCenter);
            return true;
        }else if (indexCenter < indexAbove)
        {
            Debug.Log("center:" + indexCenter + "above:" + indexAbove);
            return true;
        }
        return false;

    }
    public static bool IsComplete()
    {
        bool isFalse = true;
        string stringList = "";
        if (!listState.Contains((int)EnumState.above))
        {
            
            // Debug.Log("lack above");
            isFalse= false;
           
        }
        if (!listState.Contains((int)EnumState.center))
        {
            // Debug.Log("lack center");
            isFalse = false;
        }
        if (!listState.Contains((int)EnumState.below))
        {
            // Debug.Log("lack below");
            isFalse = false;
        }
        foreach (int item in listState)
        {
            stringList+=" "+item;
        }
        Debug.Log("sl:"+ stringList);
        return isFalse;
    }
    public static void ResetList()
    {
        listState.Clear();
    }



}
