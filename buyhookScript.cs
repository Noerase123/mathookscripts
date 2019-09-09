using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buyhookScript : MonoBehaviour {

    //public GameObject btn;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("hook1") == 1)
        {
            PlayerPrefs.SetInt("hook1", 1);	
        }
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void mybtn(GameObject btn)
    {
        if (PlayerPrefs.GetInt("hook1") == 1)
        {
            PlayerPrefs.SetInt("hook1", 0);
            btn.SetActive(false);
        }
    }

}
