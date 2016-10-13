using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Key1 : MonoBehaviour {

	public Sprite key_sprite;
	GameObject find_key_ui;
	GameObject find_door_ui;

    // Use this for initialization
    void Start () 
	{
		find_key_ui = GameObject.FindGameObjectWithTag ("key1");
		find_key_ui.GetComponent<Image> ().enabled = false;
		find_door_ui = GameObject.FindGameObjectWithTag ("Door1");
	}

    void OnTriggerEnter2D(Collider2D collision_with)
    {
        if(collision_with.gameObject.tag == "Player")
        {
            print("Key1 Taken");
			find_key_ui.GetComponent<Image> ().sprite = key_sprite;
			find_key_ui.GetComponent<Image> ().enabled = true;
			find_door_ui.SendMessage ("GetKey", true);
			Destroy (gameObject);
        }
    }
}
