using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour {

    public int LoadwithSec;
    public float seconds;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void nextscene(int loadlevel)
    {
        SceneManager.LoadScene(loadlevel);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void SceneloadwithSec()
    {
        StartCoroutine(loading());
    }

    IEnumerator loading()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(LoadwithSec);
    }
}
