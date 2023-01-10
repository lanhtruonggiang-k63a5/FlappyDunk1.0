using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParralaxBackGround : MonoBehaviour
{
    public static ParralaxBackGround Instance { get; private set; }
    private SpriteRenderer sr;
    [SerializeField] private float velocityX;
    public bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            sr.size += new Vector2(velocityX, 0);
        }
    }
    

}
