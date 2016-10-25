using UnityEngine;
using System.Collections;

public class DialgoueHide : MonoBehaviour {

	public GameObject player;
	public float timeLeft = 3f;
	float temporary_timeLeft;

	// Use this for initialization
	void Start () {
		GetComponentInChildren<SpriteRenderer>().enabled = false;
		player = GameObject.FindGameObjectWithTag ("Player");
		temporary_timeLeft = timeLeft;
	}

	// Update is called once per frame
	void Update () {

		if (player.GetComponent<Player> ().in_locker == true) 
		{
			GetComponentInChildren<SpriteRenderer> ().enabled = true;
			transform.position = player.transform.position;
			timeLeft -= Time.deltaTime;
			if(timeLeft <= 0)
			{
				GetComponentInChildren<SpriteRenderer>().enabled = false;
			} 
		}
		else {
			timeLeft = temporary_timeLeft;
			GetComponentInChildren<SpriteRenderer>().enabled = false;
		}
	}
}
