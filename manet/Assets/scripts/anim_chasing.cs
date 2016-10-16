using UnityEngine;
using System.Collections;

public class anim_chasing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		bool chase = GetComponentInParent<Searching> ().is_chasing;
		if (chase) {
			GetComponent<SpriteRenderer> ().enabled = true;
		} 
		else 
		{
			GetComponent<SpriteRenderer> ().enabled = false;
		}
	
	}
}
