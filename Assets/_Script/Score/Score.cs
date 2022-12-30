using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int score { get; set; }

    [SerializeField] private int swish;
    void Start()
    {
        swish = 0;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(countScore());
    }
    private IEnumerator countScore()
    {

        if (DetectCollider.Instance.CheckSwish())
        {
            swish++;
        }
        else
        {
            swish = 0;
        }

        if (DetectCollider.Instance.CheckReverse() || DetectCollider.Instance.CheckComplete())
        {
           
        }

        yield return new WaitForSeconds(1f);
    }
}
