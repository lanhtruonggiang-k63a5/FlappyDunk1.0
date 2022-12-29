using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class HoopSpawner : MonoBehaviour
{
    public static HoopSpawner Instance { get; private set; }
    private List<GameObject> pool;
    public GameObject prefab;

    [SerializeField] private int size;
    [SerializeField] private float minHeight;
    [SerializeField] private float maxHeight;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        pool = new List<GameObject>();
        for (int i = 0; i < size; i++)
        {
            pool.Add(Instantiate(prefab));
            pool.Last().SetActive(false);
            
        }
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        StartCoroutine(SpawnHoop());
    }
    private IEnumerator SpawnHoop(){
        ActiveItem();
        yield return new WaitForSeconds(1f);

    }
    private float SetRandomHeight(){
        return UnityEngine.Random.Range(minHeight,maxHeight);
    }
    private void SetRandomPosition(GameObject obj){
        obj.transform.position = transform.position + new Vector3(0f,SetRandomHeight(),0f);
    }

    public void ActiveItem(){
        
        foreach (GameObject item in pool)
        {
            if (!item.activeSelf)
            {
                item.SetActive(true);
                SetRandomPosition(item);
                break;
            } 
        }
    }
    public void DeactiveItem(){
        pool.Last().SetActive(false);
    }
}
