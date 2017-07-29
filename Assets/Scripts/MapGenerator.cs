using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
    public float minRandom;
    public float maxRandom;
    public float spawnTime;

    public float minrandomSize;
    public float maxrandomSize;
    public float objectSize;

    public float movementSpeed;
    public float minpositionY;
    public float maxpositionY;
    bool reachedminpositionY;
    bool reachedmaxpositionY;

    public GameObject spawnPrefab;
    Transform spawnPosition;

    void Awake()
    {
        spawnPosition = gameObject.transform;
        reachedminpositionY = true;
        reachedmaxpositionY = false;
        minpositionY = spawnPosition.position.y - 1.0f;
        maxpositionY = spawnPosition.position.y + 1.0f;
    }

    void Start () {
        StartCoroutine(spawnObjects());
    }
	
	void Update () {
        movingSpawner();
        Debug.Log(spawnPosition.position);
	}
    
    // Methods

    void movingSpawner()
    {
        if (!reachedmaxpositionY)
        {
            transform.position = transform.position + new Vector3(0.0f, 1.0f, 0.0f) * movementSpeed * Time.deltaTime;
            if (transform.position.y >= maxpositionY)
            {
                reachedmaxpositionY = true;
                reachedminpositionY = false;
            }
        }
        if (!reachedminpositionY)
        {
            transform.position = transform.position + new Vector3(0.0f, -1.0f, 0.0f) * movementSpeed * Time.deltaTime;
            if (transform.position.y <= minpositionY)
            {
                reachedmaxpositionY = false;
                reachedminpositionY = true;
            }
        }
    }

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
