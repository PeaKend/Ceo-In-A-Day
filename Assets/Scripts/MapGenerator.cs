using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public float spawnTime;
    public float minRandom;
    public float maxRandom;
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
    
    float timeRandomizer ()
    {
        spawnTime = Random.Range(minRandom, maxRandom);
        return spawnTime;
    }

    IEnumerator spawnObjects()
    {
        while (true)
        {
            timeRandomizer();
            GameObject.Instantiate(spawnPrefab, spawnPosition.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
