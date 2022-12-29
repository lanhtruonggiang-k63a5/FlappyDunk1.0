using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public static BallBehavior Instance { get; private set; }

    private PolygonCollider2D pc;
    private Rigidbody2D rb;

    public PhysicsMaterial2D bounce;
    // public PhysicsMaterial2D noBounce;


    //
    [SerializeField] private float velocity;
    [SerializeField] private float gravityInGame;

    private bool startState;
    void Start()
    {
        Instance = this;
        pc = GetComponent<PolygonCollider2D>();    
        rb = GetComponent<Rigidbody2D>();
        InitialState();
    }

    // Update is called once per frame
    void Update()
    {
        OnFirstClick();
        if (OnClick())
        {
            BounceBall();
        }
    }

    bool OnClick(){
        if(startState) return Input.GetMouseButtonDown(0);
        return false;
    }
    void OnFirstClick(){
        if(Input.GetMouseButtonDown(0) && !startState){
            StartState();
        }
    }
    private void InitialState(){
        rb.sharedMaterial = null;
        rb.gravityScale = 0f;
        startState=false;
    }
    private void StartState(){
        startState=true;
        rb.gravityScale = gravityInGame;
    }
    private void BounceBall(){
        rb.velocity += Vector2.up * velocity;
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            rb.sharedMaterial = bounce;

        }
        
    }

    
}
