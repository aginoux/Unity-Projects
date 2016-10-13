using UnityEngine;
using System.Collections;

public class Door1 : MonoBehaviour {

    GameObject key1;

    [SerializeField] private bool key_taken;

    // Use this for initialization
    void Start ()
    {
        key_taken = false;
    }

	void GetKey(bool is_key_taken)
	{
		key_taken = is_key_taken;
	}
	
    void OnCollisionEnter2D(Collision2D collision_with)
    {
        //print("Door1 " + collision_with.gameObject.tag);
		if (key_taken && collision_with.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
