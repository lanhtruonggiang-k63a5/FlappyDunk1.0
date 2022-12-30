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

    //
    [SerializeField] private float spawnTime;
    private float countSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        pool = new List<GameObject>();
        for (int i = 0; i < size; i++)
        {
            pool.Add(Instantiate(prefab));
            pool[i].SetActive(false);
            
            
        }
    }
    private void Update()
    {
        if (countSpawnTime > spawnTime)
        {
            SpawnItem();
            countSpawnTime=0f;
        }
        countSpawnTime += Time.deltaTime;
    }
    private float SetRandomHeight(){
        return UnityEngine.Random.Range(minHeight,maxHeight);
    }
    private void SetRandomPosition(GameObject obj){
        obj.transform.position = transform.position + new Vector3(0f,SetRandomHeight(),0f);
    }

    public void SpawnItem(){
        
        // foreach (GameObject item in pool)
        // {
        //     if (!item.activeSelf)
        //     {
        //         item.SetActive(true);
        //         SetRandomPosition(item);
        //         break;
        //     } 
        // }
        for (int i = 0; i <= size; i++)
        {
            if (i==size)
            {
                i=0;
            }
            else if (!pool[i].activeSelf)
            {
                pool[i].SetActive(true);
                SetRandomPosition(pool[i]);
                break;
            }
        }
        // var i = 0;
        // while (!pool[i].activeSelf)
        // {
        //     pool[i].SetActive(true);
        //     SetRandomPosition(pool[i]);
        //     break;
        // }
    }
    public void DeactiveItem(){
        // pool.Last().SetActive(false);
        for (int i = 0; i < size; i++)
        {
            if (pool[i].activeSelf)
            {
                pool[i].SetActive(false);
                break;
            }
        }
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    
}
