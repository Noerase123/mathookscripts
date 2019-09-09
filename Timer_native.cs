using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer_native : MonoBehaviour {

    public Text gameTimerText;
    public float gameTimer = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameTimer -= Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        
        string timerString = string.Format("{0:0}", seconds);

        gameTimerText.text = timerString;

	}

    void useless()
    {
        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60);

        string timerString = string.Format("{0:0}:{1:00}", minutes, seconds);
    }
}
