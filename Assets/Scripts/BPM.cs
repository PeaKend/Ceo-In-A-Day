using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPM : MonoBehaviour {
    public float bpm;

    public void addBpm(float amountofBpm)
    {
        bpm += amountofBpm;
    }
}
