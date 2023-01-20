using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopRotate : MonoBehaviour
{
    public static HoopRotate Instance { get; private set; }
    private Transform tr;
    public  float angle;

    private void Start()
    {
        Instance = this;
        tr = GetComponent<Transform>();
        angle = 0.1f;
    }
    public float GenRandomAngle()
    {
        var angleZ = Mathf.Clamp(angle, -40.1f, 90.1f);
        Debug.Log("angle after gen: "+angleZ);
        return angleZ;
    }
    public void SetAngle()
    {
        tr.Rotate(new Vector3(0f,0f,GenRandomAngle()));
        Debug.Log("angle after set: "+angle);
    }
}
