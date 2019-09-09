using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelPage : MonoBehaviour {

    public GameObject cover;
    public int Loader;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(finishpanel());
	}

    IEnumerator finishpanel()
    {
        yield return new WaitForSeconds(0.5f);
        cover.SetActive(false);
    }

    public void Sceneload()
    {
        StartCoroutine(loading());
    }

    IEnumerator loading()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(Loader);
    }

}
