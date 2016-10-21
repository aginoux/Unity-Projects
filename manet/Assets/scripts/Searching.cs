using UnityEngine;
using System.Collections;

public class Searching : MonoBehaviour {

    public float moveSpeed = 10f;
	public float waitXseconds = 3f;

    private Transform target;
    private bool heard_noise;
    private Transform noise_position;
	private Vector3 dir = new Vector3 ();
	public bool is_chasing = false;
	public GameObject player;
	public Vector3 last_target;

	// Use this for initialization
	void Start () {
		last_target = transform.position;
        target = Waypoints.points[0];
        heard_noise = false;
	}
	
	// Update is called once per frame
	void Update () {

        dir = target.position - transform.position;
        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);

		if (Vector3.Distance(transform.position, target.position) <= 0.2f && !heard_noise && !is_chasing)
		{
            GetNextWaypoint(false);
        }
        else if (heard_noise && !is_chasing)
        {
            GetNextWaypoint(true);
        }
    }

    void GetNextWaypoint(bool is_it_noisy)
    {
		last_target = target.position;
        if (!is_it_noisy)
        {
            target = Waypoints.points[randWaypoints()];
        }
        else if(is_it_noisy)
        {
            target = noise_position;
            heard_noise = false;
        }

		transform.rotation = Quaternion.FromToRotation (last_target, target.position);
    }

    int randWaypoints()
    {
        return Random.Range(0, Waypoints.points.Length);
    }

    void teleportToNoiseLocation(Transform position)
    {
        heard_noise = true;
        noise_position = position;
    }

	void OnTriggerEnter2D(Collider2D collision_with)
	{
		if (collision_with.gameObject.tag == "Player")
		{
			/*Vector3 end = new Vector3 (transform.position.x, transform.position.y, -5);
			Vector3 start = new Vector3 (collision_with.gameObject.transform.position.x, collision_with.gameObject.transform.position.y, -5);
			RaycastHit2D hit = Physics2D.Raycast (start, end - start);
			Debug.DrawRay(start, end - start);
			print (hit.collider.tag);

			if (hit.collider.gameObject.CompareTag("wall"))
			{
				Debug.DrawRay(transform.position, collision_with.gameObject.transform.position - transform.position, Color.red);
				is_chasing = false;
			} 
			else 
			{
				target = collision_with.gameObject.transform;
				is_chasing = true;
			}*/
			target = collision_with.gameObject.transform;
			is_chasing = true;
		}
	}

	void OnTriggerExit2D(Collider2D collision_with)
	{
		if (collision_with.gameObject.tag == "Player")
		{
			target = Waypoints.points[randWaypoints()];
			heard_noise = false;
			is_chasing = false;
		}
	}
		
}
