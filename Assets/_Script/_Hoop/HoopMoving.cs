using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMoving : MonoBehaviour
{
    public static HoopMoving Instance { get; private set; }
    [SerializeField] private float velocity;

    private void Start()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocity * Time.deltaTime);
    }


}
