using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyDrop : MonoBehaviour {
    public float dropRate;
    public GameObject money;
    float bpmAmount;

    void Awake()
    {
        StartCoroutine(dropMoney());
    }

    IEnumerator dropMoney()
    {
        while (true)
        {
            bpmAmount = GameObject.FindGameObjectWithTag("GameController").GetComponent<BPM>().bpm;
            Instantiate(money, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.0f / ((dropRate / 100.0f) * (bpmAmount - 89.0f)));
        }
    }
}
