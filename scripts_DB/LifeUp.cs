using UnityEngine;
using System.Collections;

public class LifeUp : MonoBehaviour {

	public int max_life = 3;
	public int add_x_life = 1;
	
	void OnTriggerEnter2D(Collider2D collision_with)
	{
		if (collision_with.gameObject.tag == "Player")
		{
			int player_health;
			player_health = collision_with.GetComponent<Health> ().current_health;
			if (player_health < max_life)
			{
				collision_with.gameObject.SendMessage ("addLife", add_x_life);
				Destroy (gameObject);
			}
		}
	}
}
