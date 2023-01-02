using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMoving : MonoBehaviour
{
    
    [SerializeField] private float velocity;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*velocity*Time.deltaTime);
    }
}