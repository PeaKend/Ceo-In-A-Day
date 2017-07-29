using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public float spawnTime;
    public float minRandom;
    public float maxRandom;
    public float objectSize;
    public float minrandomSize;
    public float maxrandomSize;
    public GameObject spawnPrefab;
    Transform spawnPosition;

    void Awake()
    {
        spawnPosition = gameObject.transform;    
    }

    void Start () {
        StartCoroutine(spawnObjects());
    }
	
	void Update () {
		
	}
    
    // Methods

    float timeRandomizer ()
    {
        spawnTime = Random.Range(minRandom, maxRandom);
        return spawnTime;
    }

    float sizeRandomizer ()
    {
        objectSize = Random.Range(minrandomSize, maxrandomSize);
        return objectSize;
    }

    IEnumerator spawnObjects()
    {
        GameObject instantiatedObject;
        while (true)
        {
            timeRandomizer();
            sizeRandomizer();
            instantiatedObject = GameObject.Instantiate(spawnPrefab, spawnPosition.position, Quaternion.identity);
            instantiatedObject.transform.localScale = new Vector3(objectSize, instantiatedObject.transform.localScale.y, 1.0f);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
