using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMoving : MonoBehaviour
{
    public static HoopMoving Instance { get; private set; }
    [SerializeField] private float velocity;

    public GameObject point1;
    public GameObject point2;

    private float p1X, p1Y;
    private float p2X, p2Y;


    private void Start()
    {
        p1X = point1.transform.position.x;
        p1Y = point1.transform.position.y;
        p2X = point2.transform.position.x;
        p2X = point2.transform.position.y;

        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        var posX = transform.position.x;
        var posY = transform.position.y;

        if (p1Y < posY + 0.005f || p1Y > posY - 0.005f)
        {
            transform.Translate(new Vector2(p1X - posX, p1Y - posY) * velocity * Time.deltaTime);
        }
        else
        {
            transform.Translate(new Vector2(p2X - posX, p2Y - posY) * velocity * Time.deltaTime);
        }
    }


}
