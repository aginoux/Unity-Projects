using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

	public int level;

	void OnTriggerEnter2D(Collider2D collision_with)
	{
		if (collision_with.gameObject.tag == "Player") 
		{
			SceneManager.LoadScene(level);
		}
	}
}
