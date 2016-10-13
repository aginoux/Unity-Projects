using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

    public float moveSpeed = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    private bool heard_noise;
    private Transform noise_position;

	// Use this for initialization
	void Start () {
        target = Waypoints.points[0];
        heard_noise = false;
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f && !heard_noise){
            GetNextWaipoint(false);
        }
        if (heard_noise)
        {
            GetNextWaipoint(true);
        }
    }

    void GetNextWaipoint(bool is_it_noisy)
    {
        if (!is_it_noisy)
        {
            target = Waypoints.points[randWaypoints()];
        }
        else if(is_it_noisy)
        {
            target = noise_position;
            heard_noise = false;
        }
    }

    int randWaypoints()
    {
        return Random.Range(0, Waypoints.points.Length);
    }
	void OnTriggerEnter2D(Collider2D collision_with)
    {
        if (collision_with.gameObject.tag == "Player")
        {
            collision_with.gameObject.SendMessage("ApplyDamage", 1);
        }
    }

    void teleportToNoiseLocation(Transform position)
    {
        heard_noise = true;
        noise_position = position;
    }
}
