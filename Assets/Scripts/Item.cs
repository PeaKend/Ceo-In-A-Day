using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public float itemBpm;
    BPM bpmScript;

    void Awake()
    {
        bpmScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<BPM>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            bpmScript.addBpm(itemBpm);
            Destroy(gameObject);
        }
    }


}
