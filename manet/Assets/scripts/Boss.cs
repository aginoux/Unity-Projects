using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision_with)
    {
        if (collision_with.gameObject.tag == "Player")
        {
            collision_with.gameObject.SendMessage("ApplyDamage", 1);
        }
    }
}
