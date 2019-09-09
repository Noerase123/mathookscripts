using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public GameObject Claw;
	public bool isShooting;
	public Animator playerheadAnimator;
	public Claw clawScript;
	
	void Update () {
        if (Input.GetButtonDown("Fire1") && !isShooting)
        {
            LaunchClaw();
        }
	}
	void LaunchClaw ()
	{
	     isShooting = true;
		 playerheadAnimator.speed = 0;
		 RaycastHit hit;
		 Vector3 up = transform.TransformDirection(Vector3.up);
		 
		 if(Physics.Raycast(transform.position , up , out hit, 1000))
		 {
			 Claw.SetActive(true);
			 clawScript.ClawTarget(hit.point);
		 }
	}
	public void CollectedObject() {
	    isShooting = false;
		playerheadAnimator.speed = 1;
	}

}
