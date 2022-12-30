using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    public static DetectCollider Instance { get; private set; }

    public List<int> listState;
    void Start()
    {
        Instance = this;
        listState = new List<int>();
    }
    public bool CheckSwish()
    {
        if (listState.Contains((int)EnumState.edge))
        {
            return false;
        }
        return true;
    }
    public bool CheckReverse()
    {
        var indexBelow = listState.LastIndexOf((int)EnumState.below);
        var indexCenter = listState.LastIndexOf((int)EnumState.center);
        var indexAbove = listState.LastIndexOf((int)EnumState.above);
        if(indexBelow<indexCenter || indexCenter< indexAbove){
            return true;
        }
        return false;

    }
    public bool CheckComplete(){
        return listState.Contains((int)EnumState.above)
            && listState.Contains((int)EnumState.center)
            && listState.Contains((int)EnumState.below);
    }
    public void ResetList(){
        listState.Clear();
    }
    


}
