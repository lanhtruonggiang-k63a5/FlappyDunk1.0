using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopMoving : MonoBehaviour
{
    public static HoopMoving Instance { get; private set; }
    [SerializeField] private float velocity;

    [SerializeField] private GameObject[] waypoints;
    private int currentWayPointsIndex = 0;

    private bool isMoving;
    private void Start()
    {


        Instance = this;
        isMoving = true;
    }
    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(waypoints[currentWayPointsIndex].transform.position, transform.position) < 0.1f)
        {

            currentWayPointsIndex += 1;
            if (currentWayPointsIndex >= waypoints.Length)
            {
                currentWayPointsIndex = 0;
            }

        }
        if (isMoving)
        {
            transform.position =
            Vector2.MoveTowards(transform.position,
                                 waypoints[currentWayPointsIndex].transform.position,
                                  Time.deltaTime * velocity);
        }
    }
    public void SetIsMoving(bool moving){
        isMoving = moving;
    }
}



