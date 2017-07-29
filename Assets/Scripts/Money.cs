using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour {

    void Awake()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2 (Random.Range(-10.0f, 10.0f),
                                                                     Random.Range(0.0f, 10.0f)),
                                                        ForceMode2D.Impulse);
        StartCoroutine(destroyMoney());
    }

    IEnumerator destroyMoney()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);
    }
}
