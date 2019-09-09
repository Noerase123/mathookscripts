using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Claw : MonoBehaviour {

    public int coinValue;
    public int errorLoad;
    public GameObject correct;
    public GameObject wrong;
    public GameObject wrong2;
    public GameObject apple;
    public GameObject apple2;
    public GameObject finishPanel;
    //public Text scoretxt;
    int score = 0;
    int dbscore = 0;
    int error = 2;
	public Transform Origin;
	public float speed = 350f;
	public Gun gun;
	//add scoremanager variable
	
	private Vector3 target;
	private int appleValue = 100;
	private GameObject childObject;
	private LineRenderer lineRenderer;
	private bool hitApple;
    private bool retracting;

    int setscore;
	
	void Awake ()
	{
		lineRenderer = GetComponent<LineRenderer>();
	}
	
	void Update () 
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target, step);
		lineRenderer.SetPosition(0, Origin.position);
		lineRenderer.SetPosition(1, transform.position);
		if (transform.position == Origin.position && retracting)
		{
			gun.CollectedObject();
			if (hitApple)
			{
				//add points
				hitApple = false;
			}
			Destroy(childObject);
			gameObject.SetActive(false);
		}
        int addscore = coinValue;

        if (score == addscore)
        {
            correct.SetActive(true);
            //finishPanel.SetActive(true);
            Destroy(apple);
            Destroy(apple2);
            StartCoroutine(finish());
        }

        if (error == 0)
        {
            Debug.Log("Gameover");
            SceneManager.LoadScene(errorLoad);
        }
	}

    IEnumerator finish()
    {
        yield return new WaitForSeconds(0.5f);
        finishPanel.SetActive(true);
    }
	
	public void ClawTarget (Vector3 pos)
	{
		target = pos;
	}
	
	void OnTriggerEnter (Collider other)
	{
		retracting = true;
		target = Origin.position;
		
		if (other.gameObject.CompareTag("Apple"))
        {
            score = score + coinValue;
            
            dbscore = PlayerPrefs.GetInt("score") + score;
            setscore = PlayerPrefs.GetInt("coins") + score;
            PlayerPrefs.SetInt("coins", setscore);
            //PlayerPrefs.SetInt("score", dbscore);

            if (PlayerPrefs.HasKey("Player"))
            {
                PlayerPrefs.SetInt("score", dbscore);
            }
            else if (PlayerPrefs.HasKey("Player2"))
            {
                PlayerPrefs.SetInt("score", dbscore);
            }
            else if (PlayerPrefs.HasKey("Player3"))
            {
                PlayerPrefs.SetInt("score", dbscore);
            }

            Debug.Log("You earn " + score +  ". Now you have " + PlayerPrefs.GetInt("coins"));
            hitApple = true;
			childObject = other.gameObject;
			other.transform.SetParent(this.transform);
		}
        else if (other.gameObject.CompareTag("wrong"))
        {
            error = error - 1;
            Debug.Log("You only have " + error + ".");
            wrong.SetActive(true);
            Destroy(apple);
            hitApple = true;
        }
        else if (other.gameObject.CompareTag("wrong2"))
        {
            error = error - 1;
            Debug.Log("You only have " + error + ".");
            wrong2.SetActive(true);
            Destroy(apple2);
            hitApple = true;
        }
	}
}
