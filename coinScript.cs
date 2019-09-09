using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class coinScript : MonoBehaviour {

    public Text cointxt;

    public int hook1_cost = 25;
    int setcoins;

	// Use this for initialization
	void Start () {
        cointxt.text = "Coins : " + PlayerPrefs.GetInt("coins");
	}
	
	// Update is called once per frame
	void Update () {
        cointxt.text = "Coins : " + PlayerPrefs.GetInt("coins");
		
	}


    public void BuyHook1()
    {

        if (PlayerPrefs.GetInt("coins") >= hook1_cost)
        {
            setcoins = PlayerPrefs.GetInt("coins") - hook1_cost;
            PlayerPrefs.SetInt("coins", setcoins);
        }
        else
        {
            Debug.Log("Insufficient coins!");
        }
        
    }
}
