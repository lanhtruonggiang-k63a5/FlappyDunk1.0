using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }    
    
    
    void Start()
    {
        Instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    


}
