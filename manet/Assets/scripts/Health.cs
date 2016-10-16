using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

	public float invicibleXseconds = 2;
	public int current_health = 3;
	GameObject find_health_ui;
	public Sprite no_heart;
	public Sprite one_heart;
	public Sprite two_hearts;
	public Sprite three_hearts;
	public AudioSource music_theme;


	// Use this for initialization
	void Start () {
		find_health_ui = GameObject.FindGameObjectWithTag ("health_ui");
		find_health_ui.GetComponent<Image> ().sprite = three_hearts;

	}
	
	// Update is called once per frame
	void Update () {
		if (current_health == 3) 
		{
			if (music_theme.pitch > 1) 
			{
				music_theme.pitch -= 1 * Time.deltaTime/2;
			}
		}
		if (current_health == 2) 
		{
			if (music_theme.pitch <= 2) 
			{
				music_theme.pitch += 1 * Time.deltaTime;
			}
			if (music_theme.pitch > 2) 
			{
				music_theme.pitch -= 1 * Time.deltaTime;
			}
		}
		if (current_health == 1) 
		{
			if (music_theme.pitch <= 3) 
			{
				music_theme.pitch += (1 * Time.deltaTime/2);
			}
		}
	}

	void ApplyDamage(int damage)
	{
		if (current_health > 0) 
		{
			current_health -= damage;
		}
		showHealth (current_health);
	}

	void addLife(int life)
	{
		if (current_health > 0 && current_health < 3) 
		{
			current_health += life;
		}
		print (current_health);
		showHealth (current_health);
	}

	void showHealth(int current_health)
	{
		if (current_health == 3) 
		{
			find_health_ui.GetComponent<Image> ().sprite = three_hearts;
			music_theme.pitch = 1;
		}
		if (current_health == 2) 
		{
			find_health_ui.GetComponent<Image> ().sprite = two_hearts;
		}
		if (current_health == 1) 
		{
			find_health_ui.GetComponent<Image> ().sprite = one_heart;
			music_theme.pitch = 3;
		}
		if (current_health == 0) 
		{
			find_health_ui.GetComponent<Image> ().sprite = no_heart;
			SceneManager.LoadScene (0);
		}
	}
		
}
