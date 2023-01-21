using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Obsolete]
public class BallFollow : MonoBehaviour
{
    private Transform tf;
    [SerializeField] private float shiftX;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }
    void Update()
    {
        if (GameManager.Instance.EndlessGame.activeSelf)
        {
            tf.position = new Vector3(
                                BallBehavior.Instance.transform.position.x + shiftX,
                                transform.position.y,
                                transform.position.z);
        }
    }
}
