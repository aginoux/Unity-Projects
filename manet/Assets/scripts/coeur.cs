﻿using UnityEngine;
using System.Collections;

public class coeur : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collision_with)
	{
		if (collision_with.gameObject.tag == "Player")
		{
			int player_health;
			player_health = collision_with.GetComponent<Health> ().current_health;
			if (player_health < 3)
			{
				collision_with.gameObject.SendMessage ("addLife", 1);
				Destroy (gameObject);
			}
		}
	}
}
