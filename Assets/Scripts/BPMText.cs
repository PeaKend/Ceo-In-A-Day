using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BPMText : MonoBehaviour {
	
    public void updateText(float bpm)
    {
        gameObject.GetComponent<Text>().text = bpm.ToString();
    }
}
