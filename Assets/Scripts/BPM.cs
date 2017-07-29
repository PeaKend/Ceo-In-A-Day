using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPM : MonoBehaviour {
    public float bpm;
    BPMText bpmtextGameobject;
    
    private void Awake()
    {
        bpmtextGameobject = GameObject.FindGameObjectWithTag("BPMCounter").GetComponent<BPMText>();
        addBpm(1.0f);
    }

    public void addBpm(float amountofBpm)
    {
        bpm += amountofBpm;
        bpmtextGameobject.updateText(bpm);
    }
}
