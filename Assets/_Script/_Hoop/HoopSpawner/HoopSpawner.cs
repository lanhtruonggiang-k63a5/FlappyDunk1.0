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
    public GameObject hoopContainer;

    [SerializeField] private int sizePool;
    [SerializeField] private float minHeight;
    [SerializeField] private float maxHeight;
    //
    [SerializeField] private float spawnTime;
    private float countSpawnTime;
    // Start is called before the first frame update


// HoopSpawner work???
// Start: make a Queue(FIFO) pool, create all Instance obj.
// set them all false, add to queue.
// Update: when countSpawn > spawn time-> SpawnItem() and reset time.
// SpawnItem : dequeue(remove) obj, active it, set position and enqueue(add) obj.
    void Start()
    {
        Instance = this;
        pool = new Queue<GameObject>();
        for (int i = 0; i < sizePool; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.parent = hoopContainer.transform; 
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
    public void SpawnItem()
    {
        GameObject objectToSpawn = pool.Dequeue();
        objectToSpawn.SetActive(true);
        // DisappearDetect.Instance.Appear();
        
        
        SetRandomPosition(objectToSpawn);
        pool.Enqueue(objectToSpawn);
    }
    
    
    private float SetRandomHeight()
    {
        return UnityEngine.Random.Range(minHeight, maxHeight);
    }
    private void SetRandomPosition(GameObject obj)
    {
        obj.transform.position = transform.position + new Vector3(0f, SetRandomHeight(), 0f);
    }
    


    
   
}
