using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEditor;
using UnityEngine.SceneManagement;
using System.Security.Cryptography.X509Certificates;

public class Player : MonoBehaviour {

    /*
    private Rigidbody2D mrb2D;
    //Movement
    private float moveSpeed;
    public float walkSpeed;
    public float runSpeed;

    //Direction of the player
    [SerializeField]
    private bool right;
    [SerializeField]
    private bool left;
    [SerializeField]
    private bool up;
    [SerializeField]
    private bool down;

    [SerializeField]
    private bool was_right;
    [SerializeField]
    private bool was_left;
    [SerializeField]
    private bool was_up;
    [SerializeField]
    private bool was_down;

    [SerializeField]
    private string lastKey;
    [SerializeField]
    private string befKey;


    // Use this for initialization
    void Start()
    {
        //Initialisation of the player's direction at the right
        right = true;
        left = false;
        up = false;
        down = false;
        lastKey = "";
        befKey = "";
        mrb2D = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Is the player walking or running? 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //running speed
            moveSpeed = runSpeed;
        }
        else
        {
            //walking sped
            moveSpeed = walkSpeed;
        }

        //Check for the direction, when a direction is chosen, it is set to true, all the others directions are set to false 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (!was_left)
            {
                lastKey = "left";
            }
            else if (was_left && lastKey != "left")
            {
                befKey = "left";
            }
            else if(was_left && befKey == "left")
            {
                lastKey = "left";
            }
            was_left = true;
        }
        else
        {
            was_left = false;
            lastKey = befKey;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!was_right)
            {
                lastKey = "right";
            }
            else if (was_right && lastKey != "right")
            {
                befKey = "right";
            }
            else if (was_right && befKey == "right")
            {
                lastKey = "right";
            }
            was_right = true; 
        }
        else
        {
            was_right = false;
            lastKey = befKey;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (!was_up)
            {
                lastKey = "up";
            }
            else if (was_up && lastKey != "up")
            {
                befKey = "up";
            }
            else if (was_up && befKey == "up")
            {
                lastKey = "up";
            }
            was_up = true;
        }
        else
        {
            was_up = false;
            lastKey = befKey;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (!was_down)
            {
                lastKey = "down";
            }
            else if (was_down && lastKey != "down")
            {
                befKey = "down";
            }
            else if (was_down && befKey == "down")
            {
                lastKey = "down";
            }
            was_down = true;
        }
        else
        {
            was_down = false;
            lastKey = befKey;
        }

        if (was_left && lastKey == "left" )
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            right = false;
            left = true;
            up = false;
            down = false;
        }
        if (was_right && lastKey == "right")
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            right = true;
            left = false;
            up = false;
            down = false;
        }
        if (was_up && lastKey == "up")
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            right = false;
            left = false;
            up = true;
            down = false;
        }
        if (was_down && lastKey == "down")
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
            right = false;
            left = false;
            up = false;
            down = true;
        }



        //Call the flip fonction, which will flip the player according to his direction
        Flip();
    }

    //Function to flip the player's image according to the direction chosen
    private void Flip()
    {
        //Important to differentiate vertical and horizontal directions
        if (right || left)
        {
            //In vertical direction, you have to be sure z position in the transform.Rotation is 0
            Vector3 theScale1 = transform.localEulerAngles;
            theScale1.z = 0;
            transform.localEulerAngles = theScale1;

            //if the key is right, then x of tranform.scale is set to 1
            if (right)
            {
                Vector3 theScale = transform.localScale;
                theScale.x = 1;
                transform.localScale = theScale;
                //print(1);
            }
            //if the key is right, then x of tranform.scale is set to -1
            else if (left)
            {
                Vector3 theScale = transform.localScale;
                theScale.x = -1;
                transform.localScale = theScale;
                //print(-1);
            }
        }
        //Important to differentiate vertical and horizontal directions
        else if (up || down)
        {
            //In horizontal direction, you have to be sure x position in the transform.Scale is 1
            Vector3 theScale2 = transform.localScale;
            theScale2.x = 1;
            transform.localScale = theScale2;

            //if the key is up, then z of tranform.Rotation is set to 90
            if (up)
            {
                Vector3 theScale = transform.localEulerAngles;
                theScale.z = 90;
                transform.localEulerAngles = theScale;
                //print(90);
            }
            //if the key is down, then z of tranform.Rotation is set to -90
            else if (down)
            {
                Vector3 theScale = transform.localEulerAngles;
                theScale.z = -90;
                transform.localEulerAngles = theScale;
                //print(-90);
            }
        }    
    }
    */

    //Movement
    private float moveSpeed;
    public float walkSpeed;
    public float runSpeed;
	public string tag_locker;
	public float radius_circle_detection =2.5f;
	public bool in_locker;
	public bool can_move;


    //Direction of the player
	private bool right;
	private bool left;
	private bool up;
	private bool down;

	public bool going_right;
	public bool going_left;
	public bool going_up;
	public bool going_down;
	public bool action_player;
	public bool sprintting_player;
	public bool test = false;

    // Use this for initialization
    void Start()
    {
        //Initialisation of the player's direction at the right
		going_right = false;
		going_left = false;
		going_up = false;
		going_down = false;
		sprintting_player = false;
		action_player = false;
        right = true;
        left = false;
        up = false;
        down = false;
		in_locker = false;
		can_move = true;
        //transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Is the player walking or running? 
		if (Input.GetKey(KeyCode.LeftShift) || sprintting_player)
        {
            //running speed
            moveSpeed = runSpeed;
        }
        else
        {
            //walking sped
            moveSpeed = walkSpeed;
        }
		if (can_move) 
		{
			//Check for the direction, when a direction is chosen, it is set to true, all the others directions are set to false 
			if (Input.GetKey (KeyCode.LeftArrow) || going_left) {
				transform.position += Vector3.left * moveSpeed * Time.deltaTime;
				right = false;
				left = true;
				up = false;
				down = false;
			} else if (Input.GetKey (KeyCode.RightArrow) || going_right) {
				transform.position += Vector3.right * moveSpeed * Time.deltaTime;
				right = true;
				left = false;
				up = false;
				down = false;
			} else if (Input.GetKey (KeyCode.UpArrow) || going_up) {
				transform.position += Vector3.up * moveSpeed * Time.deltaTime;
				right = false;
				left = false;
				up = true;
				down = false;
			} else if (Input.GetKey (KeyCode.DownArrow) || going_down) {
				transform.position += Vector3.down * moveSpeed * Time.deltaTime;
				right = false;
				left = false;
				up = false;
				down = true;
			} 
			else 
			{
				going_right = false;
				going_left = false;
				going_up = false;
				going_down = false;
			}

			//Call the flip fonction, which will flip the player according to his direction
			Flip();
		}

		//check if close to a hideout.
		if(Input.GetKeyDown(KeyCode.E) || action_player)
		{
			test = !test;
			if (!in_locker) {
				Collider2D[] detected_it = Physics2D.OverlapCircleAll (transform.position, radius_circle_detection);
				int i = 0;
				while (i < detected_it.Length) {
					if (detected_it [i].tag == tag_locker) {
						EnterLocker ();
						in_locker = true;
						can_move = false;
						return;
					}
					i++;
				}
			} else {
				ExitLocker ();
				can_move = true;
				in_locker = false;
				//print (in_locker);
			}
		}
			
    }
		
	private void EnterLocker()
	{
		GameObject find_boss = GameObject.FindGameObjectWithTag ("boss");
		find_boss.GetComponent<Searching>().is_chasing = false;
		GetComponent<SpriteRenderer> ().enabled = false;
		GetComponent<BoxCollider2D>().enabled = false;
	}

	private void ExitLocker()
	{
		GetComponent<SpriteRenderer> ().enabled = true;
		GetComponent<BoxCollider2D>().enabled = true;
	}

    //Function to flip the player's image according to the direction chosen
    private void Flip()
    {
        //Important to differentiate vertical and horizontal directions
        if (right || left)
        {
            //In vertical direction, you have to be sure z position in the transform.Rotation is 0
            Vector3 theScale1 = transform.localEulerAngles;
            theScale1.z = 0;
            transform.localEulerAngles = theScale1;

            //if the key is right, then x of tranform.scale is set to 1
            if (right)
            {
                Vector3 theScale = transform.localScale;
                theScale.x = 1;
                transform.localScale = theScale;
                //print(1);
            }
            //if the key is right, then x of tranform.scale is set to -1
            else if (left)
            {
                Vector3 theScale = transform.localScale;
                theScale.x = -1;
                transform.localScale = theScale;
                //print(-1);
            }
        }
        //Important to differentiate vertical and horizontal directions
        else if (up || down)
        {
            //In horizontal direction, you have to be sure x position in the transform.Scale is 1
            Vector3 theScale2 = transform.localScale;
            theScale2.x = 1;
            transform.localScale = theScale2;

            //if the key is up, then z of tranform.Rotation is set to 90
            if (up)
            {
                Vector3 theScale = transform.localEulerAngles;
                theScale.z = 90;
                transform.localEulerAngles = theScale;
                //print(90);
            }
            //if the key is down, then z of tranform.Rotation is set to -90
            else if (down)
            {
                Vector3 theScale = transform.localEulerAngles;
                theScale.z = -90;
                transform.localEulerAngles = theScale;
                //print(-90);
            }
        }    
    }

    void OnCollisionEnter2D(Collision2D collision_with)
    {
        //print("Player " + collision_with.gameObject.tag);
    }

    void OnTriggerEnter2D(Collider2D collision_with)
    {
		if (collision_with.gameObject.tag == "Finish")
		{
			SceneManager.LoadScene (0);
		}
    }

	public void OnPressedButton(int button)
	{
		if (button == 0) {
			going_left = true;
			going_right = false;
			going_up = false;
			going_down = false;
		} else if (button == 1) {
			going_left = false;
			going_right = true;
			going_up = false;
			going_down = false;
		} else if (button == 2) {
			going_left = false;
			going_right = false;
			going_up = false;
			going_down = true;
		} else if (button == 3) {
			going_left = false;
			going_right = false;
			going_up = true;
			going_down = false;
		}
	}

	public void OnActionButtonPressed()
	{
		StartCoroutine (wait ());
	}

	public void OnSprinttingButtonPressed()
	{
		sprintting_player = true;
	}

	public void ReleasePressedButton()
	{
			going_left = false;
			going_right = false;
			going_up = false;
			going_down = false;
			sprintting_player = false;
	}

	IEnumerator wait()
	{
		action_player = true;
		yield return new WaitForSeconds (0.02f);
		action_player = false;
	}
    //END VERSION 1.0

    





    /*
    private Rigidbody2D mrb2D;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private bool facingRight;
    [SerializeField]
    private bool facingUp;
    [SerializeField]
    private bool hor;
    [SerializeField]
    private bool up;
    [SerializeField]
    private bool right;
    [SerializeField]

    // Use this for initialization
    void Start()
    {
        hor = true;
        up = false;
        right = true;
        facingRight = true;
        facingUp = false;
        mrb2D = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            hor = true;
            right = false;

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            hor = true;
            right = true;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            hor = false;
            up = true;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
            hor = false;
            up = false;
        }
        Flip();
    }

    private void Flip()
    {
        if (hor)
        {
            Vector3 theScale1 = transform.localEulerAngles;
            theScale1.z = 0;
            transform.localEulerAngles = theScale1;
            facingUp = false;
            if (right && !facingRight)
            {
                facingRight = !facingRight;
                Vector3 theScale = transform.localScale;
                theScale.x = 1;
                transform.localScale = theScale;
                print(1);
            }
            if (!right && facingRight)
            {
                facingRight = !facingRight;
                Vector3 theScale = transform.localScale;
                theScale.x = -1;
                transform.localScale = theScale;
                print(-1);
            }
        }
        if (!hor)
        {
            Vector3 theScale2 = transform.localScale;
            theScale2.x = 1;
            transform.localScale = theScale2;
            facingRight = false;
            if (up && !facingUp)
            {
                facingUp = !facingUp;
                Vector3 theScale = transform.localEulerAngles;
                theScale.z = 90;
                transform.localEulerAngles = theScale;
                print(90);
            }
            if (!up && facingUp)
            {
                facingUp = !facingUp;
                Vector3 theScale = transform.localEulerAngles;
                theScale.z = -90;
                transform.localEulerAngles = theScale;
                print(-90);
            }
        }
    }
    */

    /*

private Rigidbody2D mrb2D;

[SerializeField]
private float moveSpeed;

private bool facingRight;
private bool facingUp;

[SerializeField]
private float hor;

[SerializeField]
private float ver;

// Use this for initialization
void Start () {
    facingRight = true;
    mrb2D = GetComponent<Rigidbody2D>();
    transform.position = new Vector3(0, 0, 0);
}

// Update is called once per frame
void Update () {

    hor = Input.GetAxis("Horizontal");
    ver = Input.GetAxis("Vertical");

    if (hor < 0)
    {
        HandleMovement(-1, 0);
    }
    else if(hor > 0)
    {
        HandleMovement(1, 0);
    }
    else if (ver < 0)
    {
        HandleMovement(0, -1);
    }
    else if (ver >  0)
    {
        HandleMovement(0, 1);
    }
    Flip(hor);


}

private void HandleMovement(float hor, float ver)
{
    mrb2D.velocity = new Vector3(hor * moveSpeed,ver * moveSpeed,0);
    //transform.position = new Vector3(btn0, btn1, 0);
}
private void Flip(float hor)
{
    if (hor > 0 && !facingRight || hor < 0 && facingRight)
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
*/
}
