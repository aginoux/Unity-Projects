using UnityEngine;
using System.Collections;

public class FocusCamera : MonoBehaviour {

    public GameObject player;
	public float new_position_z = -10;
	public float add_view_x = 0;
	public float add_view_y = 0;
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x + add_view_x, player.transform.position.y + add_view_y, new_position_z);
	}
}
