using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    //Singleton
    public static BallBehavior Instance { get; private set; }


    //Component
    private PolygonCollider2D pc;
    private Rigidbody2D rb;

    public PhysicsMaterial2D bounce;
    // public PhysicsMaterial2D noBounce;


    //[SerializeField]
    [SerializeField] private float velocity;
    [SerializeField] private float gravityInGame;

    //public
    

    //private
    private bool startState;
    public bool isDeath;

    void Start()
    {
        Instance = this;
        pc = GetComponent<PolygonCollider2D>();    
        rb = GetComponent<Rigidbody2D>();
        InitialState();
    }

    // Update is called once per frame
    void FixUpdate()
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
