using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

    public float moveSpeed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

	// Use this for initialization
	void Start () {
        target = Waypoints.points[0];
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f){
            GetNextWaipoint();
        }
	}

    void GetNextWaipoint()
    {
        target = Waypoints.points[randWaypoints()];
    }

    int randWaypoints()
    {
        return Random.Range(0, Waypoints.points.Length);
    }
    void OnCollisionEnter2D(Collision2D collision_with)
    {
        if (collision_with.gameObject.tag == "Player")
        {
            collision_with.gameObject.SendMessage("ApplyDamage", 1);
        }
    }
}
