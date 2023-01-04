using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMoving : MonoBehaviour
{
    public static HoopMoving Instance { get; private set; }
    [SerializeField] private float velocity;

    public bool isTransform;
    private void Start()
    {
        Instance = this;
        isTransform = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (isTransform)
        {
            transform.Translate(Vector3.left * velocity * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * velocity * 5 * Time.deltaTime);
        }
    }


}
