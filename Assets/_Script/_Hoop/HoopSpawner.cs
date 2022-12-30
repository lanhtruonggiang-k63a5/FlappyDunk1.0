using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class HoopSpawner : MonoBehaviour
{
    public static HoopSpawner Instance ;
    private Queue<GameObject> pool;
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
        pool = new Queue<GameObject>();
        for (int i = 0; i < size; i++)
        {
            GameObject obj = Instantiate(prefab);
            
            obj.SetActive(false);
            
            pool.Enqueue(obj);
        }
        
    }
    private void Update()
    {
        if (countSpawnTime > spawnTime)
        {
            SpawnItem();
            countSpawnTime = 0f;
        }
        countSpawnTime += Time.deltaTime;
    }
    private float SetRandomHeight()
    {
        return UnityEngine.Random.Range(minHeight, maxHeight);
    }
    private void SetRandomPosition(GameObject obj)
    {
        obj.transform.position = transform.position + new Vector3(0f, SetRandomHeight(), 0f);
    }

    public void SpawnItem()
    {
        
        GameObject objectToSpawn = pool.Dequeue();
        objectToSpawn.SetActive(true);
        SetRandomPosition(objectToSpawn);
        pool.Enqueue(objectToSpawn);
    }
   
}
