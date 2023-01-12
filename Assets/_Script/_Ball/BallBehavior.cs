using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBehavior : MonoBehaviour
{
    //Singleton
    public static BallBehavior Instance { get; private set; }

    

    //Component
    private CircleCollider2D pc;
    private Rigidbody2D rb;

    public PhysicsMaterial2D noBounce;
    public PhysicsMaterial2D bounce;
    public GameObject hoopSpawner;



    //[SerializeField]
    [SerializeField] private float velocityY;
    [SerializeField] private float gravityInGame;

    [SerializeField] private float posX;

    [SerializeField] private float velocityX;
    //public
    public bool isDeath;

    //private
    private bool ballMoveRight;
    private bool startState;
    private int countBounceOnTerrain;

    void Awake()
    {
        Instance = this;
        pc = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        InitialState();
    }

    // Update is called once per frame
    void Update()
    {
        // SetTransformX(posX);
        OnFirstClick();
        if(ballMoveRight){
            rb.velocity =  new Vector2(velocityX,rb.velocity.y) ;
            Debug.Log(Time.deltaTime);
        }
        if (OnClick() && !isDeath)
        {
            UpBall();
            WingAnimBack.Instance.CallAnimFlap();
            WingAnimFront.Instance.CallAnimFlap();
        }
        ReloadScene();
    }
    private void UpBall()
    {
        SoundManager.Instance.PlayFlap();
        // rb.velocity += Vector2.up * velocity ;
        // rb.MovePosition(Vector2.up*velocity);
        // rb.MovePosition(rb.position + Vector2.up );
        // rb.AddForce(transform.up*velocity,ForceMode2D.Impulse);
        // rb.AddRelativeForce(Vector2.up*velocity);
        // rb.AddForce(Vector2.up * velocity, ForceMode2D.Impulse);
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        // rb.velocity += Vector2.up * velocityY;
        rb.velocity = new Vector2(rb.velocity.x,velocityY);
    }
    void SetTransformX(float n)
    {
        rb.position = new Vector2(n, rb.position.y);
    }
    bool OnClick()
    {
        return Input.GetMouseButtonDown(0);
    }
    void OnFirstClick()
    {
        if (Input.GetMouseButtonDown(0) && !startState)
        {
            StartState();
        }
    }
    private void InitialState()
    {
        // rb.sharedMaterial = noBounce;
        rb.sharedMaterial = null;
        rb.gravityScale = 0f;
        startState = false;

    }
    private void StartState()
    {
        ballMoveRight = true;
        ParralaxBackGround.Instance.isMoving = true;
        startState = true;
        rb.gravityScale = gravityInGame;
        hoopSpawner.SetActive(true);
        SoundManager.Instance.PlayWhistle();
        Pause.Instance.pauseButton.SetActive(true);
    }
    


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            if (countBounceOnTerrain == 0)
            {
                SoundManager.Instance.PlayWrong();
                StartCoroutine(WingPop());
            }
            
            if (countBounceOnTerrain < 3)
            {
                SoundManager.Instance.PlayBounce();
            }
            isDeath = true;
            SetMaterialBounce();
            countBounceOnTerrain++;
        }

    }
    private IEnumerator WingPop()
    {
        SoundManager.Instance.PlayCrash();
        WingAnimFront.Instance.SetAnimChopWing();
        WingAnimBack.Instance.SetAnimChopWing();
        // WingChopTransform.Instance.ChopWing = true;
        yield return new WaitForSeconds(1f);
    }
    public void SetMaterialBounce()
    {
        rb.sharedMaterial = bounce;
    }


    public void ReloadScene()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }




}
