using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
    //todo add fadein gameobject and position
    public GameObject FadeInGameObject;
    public Transform FadeInPosition;

    //todo add fadeout gameobject and position
    public GameObject FadeOutGameObject;
    public Transform FadeOutPosition;

    //todo add scenes
    public Scene ChangeLeveScene;
    public Scene NextScene;

    //todo add a dondestroy
    //todo add a point and level time/change controller

    void Awake()
    {
        DontDestroyOnLoad(gameObject);    
    }

    void fadeIn()
    {
        Instantiate(FadeInGameObject, FadeInPosition.position, Quaternion.identity);
    }

    void fadeOut()
    {
        Instantiate(FadeOutGameObject, FadeOutPosition.position, Quaternion.identity);
    }

    IEnumerator ChangeLevel()
    {
        fadeIn();
        new WaitForSeconds(2.0f);
        SceneManager.LoadScene(NextScene.name);
        fadeOut();
        yield return null;
    }

}
