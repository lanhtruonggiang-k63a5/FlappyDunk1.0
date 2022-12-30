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
    public GameObject hoopSpawner;
    


    //[SerializeField]
    [SerializeField] private float velocity;
    [SerializeField] private float gravityInGame;

    //public
    public bool IsDeath { get; private set; }

    //private
    private bool startState;
    private int countBounceOnTerrain;

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
        if (OnClick() && !IsDeath)
        {
            UpBall();
            WingAnim.Instance.SetAnimFlap();
        }
    }

    bool OnClick(){
        return Input.GetMouseButtonDown(0);
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
        hoopSpawner.SetActive(true);
        SoundManager.Instance.PlayWhistle();

    }
    private void UpBall(){
        SoundManager.Instance.PlayFlap();
        rb.velocity += Vector2.up * velocity;
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            if(countBounceOnTerrain==0){
                SoundManager.Instance.PlayWrong();
            }
            if(countBounceOnTerrain==1){
                WingPop();
            }
            SoundManager.Instance.PlayBounce();
            IsDeath=true;
            rb.sharedMaterial = bounce;
            SoundManager.Instance.PlayCrash();
            countBounceOnTerrain++;
        }
        
    }
    private IEnumerator WingPop(){
        SoundManager.Instance.PlayCrash();
        WingAnim.Instance.SetAnimChopWing();
        yield return new WaitForSeconds(1f);
    }

    

    
}
