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

    public PhysicsMaterial2D bounce;
    public GameObject hoopSpawner;



    //[SerializeField]
    [SerializeField] private float velocity;
    [SerializeField] private float gravityInGame;

    //public
    public bool isDeath;
    
    //private
    private bool startState;
    private int countBounceOnTerrain;

    void Start()
    {
        Instance = this;
        pc = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        InitialState();
    }

    // Update is called once per frame
    void Update()
    {
        OnFirstClick();
        if (OnClick() && !isDeath)
        {
            UpBall();
            WingAnimBack.Instance.CallAnimFlap();
            WingAnimFront.Instance.CallAnimFlap();
        }
        ReloadScene();
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
        rb.sharedMaterial = null;
        rb.gravityScale = 0f;
        startState = false;
        
    }
    private void StartState()
    {
        startState = true;
        rb.gravityScale = gravityInGame;
        hoopSpawner.SetActive(true);
        SoundManager.Instance.PlayWhistle();
        Pause.Instance.pauseButton.SetActive(true);
    }
    private void UpBall()
    {
        SoundManager.Instance.PlayFlap();
        rb.velocity += Vector2.up * velocity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Terrain"))
        {
            if (countBounceOnTerrain == 0)
            {
                SoundManager.Instance.PlayWrong();
            }
            if (countBounceOnTerrain == 1)
            {
                StartCoroutine(WingPop());
            }
            SoundManager.Instance.PlayBounce();
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
        yield return new WaitForSeconds(1f);
    }
    public void SetMaterialBounce(){
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
