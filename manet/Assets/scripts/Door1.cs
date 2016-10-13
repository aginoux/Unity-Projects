using UnityEngine;
using System.Collections;

public class Door1 : MonoBehaviour {

    GameObject key1;

    [SerializeField]
    private bool key_taken;

    // Use this for initialization
    void Start ()
    {
        key_taken = false;
        key1 = GameObject.FindGameObjectWithTag("key1");
    }
	
    void OnCollisionEnter2D(Collision2D collision_with)
    {
        print("Door1 " + collision_with.gameObject.tag);
        key_taken = key1.GetComponent<Key1>().taken;
        if (key_taken)
        {
            Destroy(key1);
            Destroy(gameObject);
        }
    }
}
