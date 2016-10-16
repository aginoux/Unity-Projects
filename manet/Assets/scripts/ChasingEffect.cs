using UnityEngine;
using System.Collections;

public class ChasingEffect : MonoBehaviour {

	public AudioSource ghost_sound_effect;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		bool chase = GetComponentInParent<Searching> ().is_chasing;
		if (chase) 
		{
			GetComponent<SpriteRenderer> ().enabled = true;
		} 
		else 
		{
			GetComponent<SpriteRenderer> ().enabled = false;
		}
	
	}

	public void PlayGhostSound()
	{
		if (!ghost_sound_effect.isPlaying) 
		{		
			ghost_sound_effect.Play ();
		}
	}
}
