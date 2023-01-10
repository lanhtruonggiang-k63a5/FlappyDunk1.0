using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingChopTransform : MonoBehaviour
{   
    public static WingChopTransform Instance { get; private set; }
    private Rigidbody2D rb;
    public float UpdateX ;
    public float UpdateY ;

    public bool ChopWing;
    void Start()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        UpdateX = Mathf.Clamp(UpdateX, 1.1f, 2.1f);
        UpdateY = Mathf.Clamp(UpdateX, 1.1f, 2.1f);
        ChopWing = false;
    }
    void Update()
    {
        if(ChopWing){
            StartCoroutine(Chop());
        }
    }
    public IEnumerator Chop(){
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.velocity += Vector2.up * UpdateY;
        rb.velocity += Vector2.right * UpdateY;
        yield return new WaitForSeconds(1f);
        ChopWing=false;
    }

}
