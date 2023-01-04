using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundFollow : MonoBehaviour
{
    private Transform tf;
    [SerializeField] private float shiftX;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.position = new Vector3(
                            BallBehavior.Instance.transform.position.x + shiftX,
                            transform.position.y,
                            transform.position.z);
    }
}
