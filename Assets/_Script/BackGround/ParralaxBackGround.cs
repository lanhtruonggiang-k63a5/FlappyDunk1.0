using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParralaxBackGround : MonoBehaviour
{
    public static ParralaxBackGround Instance { get; private set; }
    private SpriteRenderer sr;
    [SerializeField] private float velocityX;
    public bool isMoving;
    private Transform currentTrf;
    private float posXCurrent;
    public Transform birdTrf;

    [SerializeField] private float minDistance;


    // Start is called before the first frame update
    void Start()
    {

        Instance = this;
        sr = GetComponent<SpriteRenderer>();
        currentTrf = GetComponent<Transform>();
        posXCurrent = currentTrf.position.x;
    }


    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            
            if (birdTrf.position.x - posXCurrent >= minDistance)
            {
                posXCurrent += minDistance;
                AddMoreBackGround();
            }
        }
    }
    public void AddMoreBackGround()
    {
        sr.size += new Vector2(velocityX, 0);
    }
}
