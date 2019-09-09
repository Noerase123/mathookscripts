using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class singlefinish : MonoBehaviour {

    public int load;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(goscene());
	}

    IEnumerator goscene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(load);
    }
}
