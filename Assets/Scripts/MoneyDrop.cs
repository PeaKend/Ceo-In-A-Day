using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyDrop : MonoBehaviour {
    public float dropRate;
    public GameObject money;

    void Awake()
    {
        StartCoroutine(dropMoney());
    }

    IEnumerator dropMoney()
    {
        while (true)
        {
            Instantiate(money, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.0f / dropRate);
        }
    }
}
