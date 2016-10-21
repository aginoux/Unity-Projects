using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeThreeHearts : MonoBehaviour {

	public float playerInvincibleXseconds = 5f;
	public int current_health = 3;
	public Sprite no_heart;
	public Sprite one_heart;
	public Sprite two_hearts;
	public Sprite three_hearts;
	public int load_this_scene_on_death = 0;
	public GameObject find_health_ui;
	bool invincible = false;
	
	// public string tag_health_ui = "health_ui";

	void Start () 
	{
		//Display life bar (at start full). find_health_ui is the object that contains sprites of health in the UI.
		//find_health_ui = GameObject.FindGameObjectWithTag (tag_health_ui);
		
		find_health_ui.GetComponent<Image> ().sprite = three_hearts;
	}
	
	void Update () {
		if (current_health == 3) 
		{
			// do stuff
		}
		if (current_health == 2) 
		{
			// do stuff
		}
		if (current_health == 1) 
		{
			// do stuff
		}
	}

	void ApplyDamage(int damage)
	{
		if(!invincible)
		{
			if (current_health > 0) 
			{
				current_health -= damage;
			}
			showHealth (current_health);
			StartCoroutine (stopTouching ());
		}
	}

	void addLife(int life)
	{
		if (current_health > 0 && current_health < 3) 
		{
			current_health += life;
		}
		//print (current_health);
		showHealth (current_health);
	}

	void showHealth(int current_health)
	{
		if (current_health == 3) 
		{
			find_health_ui.GetComponent<Image> ().sprite = three_hearts;
		}
		if (current_health == 2) 
		{
			find_health_ui.GetComponent<Image> ().sprite = two_hearts;
		}
		if (current_health == 1) 
		{
			find_health_ui.GetComponent<Image> ().sprite = one_heart;
		}
		if (current_health == 0) 
		{
			find_health_ui.GetComponent<Image> ().sprite = no_heart;
			if(load_this_scene_on_death != null)
			{
				SceneManager.LoadScene (load_this_scene_on_death);
			}
		}
	}	
	
	IEnumerator stopTouching()
	{
		invincible = true;
		yield return new WaitForSeconds(playerInvincibleXseconds);
		invincible = false;
	}
}
