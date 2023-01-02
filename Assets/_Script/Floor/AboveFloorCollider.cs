
using UnityEngine;

public class AboveFloorCollider : MonoBehaviour
{

    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        BallBehavior.Instance.SetMaterialBounce();
    }
}
