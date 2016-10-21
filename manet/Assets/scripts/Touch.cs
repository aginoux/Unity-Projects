using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {

	public float playerInvicibleXseconds = 5f;

	void OnTriggerEnter2D(Collider2D collision_with)
	{
		if (collision_with.gameObject.tag == "Player")
		{
			collision_with.gameObject.SendMessage("ApplyDamage",1);
		}
	}
}
