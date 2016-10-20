using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {

	public int damage = 1;

	void OnTriggerEnter2D(Collider2D collision_with)
	{
		if (collision_with.gameObject.tag == "Player")
		{
			collision_with.gameObject.SendMessage("ApplyDamage",damage);
		}
	}
}
