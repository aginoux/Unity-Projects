using UnityEngine;
using System.Collections;

public class Placard : MonoBehaviour {

    GameObject player;

    [SerializeField] private bool enter_placard;
    [SerializeField] private bool is_in_placard;
    [SerializeField] private bool A_pressed;
    [SerializeField] private bool E_pressed;

    // Use this for initialization
    void Start () {
        enter_placard = false;
        is_in_placard = false;
        A_pressed = false;
        E_pressed = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	/*void Update () {

        if (Input.GetKey(KeyCode.E))
        {
            E_pressed = true;
        }
        else
        {
            E_pressed = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            A_pressed = true;
        }
        else
        {
            A_pressed = false;
        }

        if (Input.GetKey(KeyCode.E) && enter_placard)
        {
            player.GetComponent<BoxCollider2D>().enabled = false;
            is_in_placard = true;
            player.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (Input.GetKey(KeyCode.A) && is_in_placard)
        {
            enter_placard = false;
            is_in_placard = false;
            player.GetComponent<BoxCollider2D>().enabled = true;
            player.GetComponent<Player>().enabled = true;
        }

        if (is_in_placard)
        {
            player.GetComponent<Player>().enabled = false;
        }
    }*/

	void Update () {

		if (Input.GetKey(KeyCode.E) && enter_placard)
		{
			player.GetComponent<BoxCollider2D>().enabled = false;
			is_in_placard = true;
			player.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
		}
		else if (Input.GetKey(KeyCode.A) && is_in_placard)
		{
			enter_placard = false;
			is_in_placard = false;
			player.GetComponent<BoxCollider2D>().enabled = true;
			player.GetComponent<Player>().enabled = true;
		}

		if (is_in_placard)
		{
			player.GetComponent<Player>().enabled = false;
		}
	}

    void OnCollisionEnter2D(Collision2D collision_with)
    {
        if (collision_with.gameObject.tag == "Player"){
            enter_placard = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision_with)
    {
        if (collision_with.gameObject.tag == "Player")
        {
            enter_placard = false;
        }
    }

}
