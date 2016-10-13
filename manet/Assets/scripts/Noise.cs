using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Noise : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collision_with)
	{
		if (collision_with.gameObject.tag == "Player") 
		{
			print ("ok");
			print (transform.parent.name);
			print (transform.parent.position);
		}
	}
}
