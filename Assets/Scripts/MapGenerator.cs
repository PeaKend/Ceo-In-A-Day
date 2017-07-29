using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public float spawnTime;
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

    IEnumerator spawnObjects()
    {
        while (true)
        {
            GameObject.Instantiate(spawnPrefab, spawnPosition.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
