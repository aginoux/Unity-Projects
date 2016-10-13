using UnityEngine;
using System.Collections;

public class Key1 : MonoBehaviour {

    [SerializeField]
    public bool taken;

    // Use this for initialization
    void Start () {
        taken = false;
	}
	

	// Update is called once per frame
	void Update () {
        if (taken)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.05f, 0.95f, 10));
        }
    }

    void OnTriggerEnter2D(Collider2D collision_with)
    {
        if(collision_with.gameObject.tag == "Player")
        {
            print("Key Taken 1 ");

            Vector3 theScale = transform.localScale;
            theScale.x = 0.4f;
            theScale.y = 0.4f;
            transform.localScale = theScale;

            taken = true;
        }
    }
}
