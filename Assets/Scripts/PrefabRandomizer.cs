using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabRandomizer : MonoBehaviour {
    public bool RandomRotation;
    public float MaxRotationAmount;

    public bool RandomScale;
    public float RandomScaleX;
    public float RandomScaleY;

    void Awake()
    {     
            if (RandomRotation)
        {
            transform.eulerAngles = new Vector3(0.0f, 
                                                0.0f,
                                                Random.Range(-MaxRotationAmount, MaxRotationAmount));
        }
            if (RandomScale)
        {
            if (RandomScaleX == 0.0f)
            {
                RandomScaleX = transform.localScale.x;
            }
            if (RandomScaleY == 0.0f)
            {
                RandomScaleY = transform.localScale.y;
            }
            transform.localScale = new Vector3(Random.Range(transform.localScale.x, RandomScaleX), 
                                               Random.Range(transform.localScale.y, RandomScaleY), 
                                               0.0f);
        }
    }
    
}
