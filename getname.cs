using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getname : MonoBehaviour {

    public Text playername;

	// Use this for initialization
	void Start () {
        playername.text = "Hi! " + PlayerPrefs.GetString("Player");
        Debug.Log(PlayerPrefs.GetString("Player") + " == " + PlayerPrefs.GetString("Player2"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
