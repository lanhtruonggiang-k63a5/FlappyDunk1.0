using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailFollow : MonoBehaviour
{
    private Transform tf;
    [SerializeField] private float shiftX;
    [SerializeField] private float shiftY;

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
                            BallBehavior.Instance.transform.position.y + shiftY,
                            transform.position.z);
    }
}
