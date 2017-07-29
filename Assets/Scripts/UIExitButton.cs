using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIExitButton : MonoBehaviour {
    Button btn;

    void Awake()
    {
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(taskonClick);
    }

    public void taskonClick()
    {
        Application.Quit();
    }


}
