using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public Animator animator;
	public float speed = 200f;
	public float timer = 0f;
	public AudioClip Walk1_Step1;
	public AudioClip Walk1_Step2;
	public AudioClip attack;
	private AudioSource source;
	private int count;
	private int aCount;
	private bool attacking = false;
	private int x = 0;

	private float jumpHeight = 10;
	public LayerMask whatIsGround;
	float groundRad = 0.2f;
	public Transform groundCheck;
	public bool grounded = false;

	public float maxSpeed = 5f;

	bool rightFace = true;
    


    // Use this for initialization
    void Start () {

        count = 0;
		aCount = 0;
        jumpHeight = 10;
        

    }

	void Awake () {

		source = GetComponent<AudioSource>();


		
	}

    void FixedUpdate()
    {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRad, whatIsGround);
        
    }

    // Update is called once per frame
    void Update () {

        if (attacking == false && grounded == true) {

			if (Input.GetAxis ("Horizontal") == 0)
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;

			//controls forward movement
			if (Input.GetAxis ("Horizontal") != 0) {
				animator.SetBool ("isWalking", true);
				transform.Translate (Vector3.right * Time.deltaTime * speed);
				if(GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed){
					GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed;
				}else
				GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
				/*
			if (count == 0) {
				source.PlayOneShot (Walk1_Step1, 1.0f);
				count++;
			}else{
					
				count++;
				if(count >= 19){ count = 0;}
			}

				*/

				if (Input.GetAxis ("Horizontal") < 0) {
					transform.rotation = Quaternion.Euler (0, 180, 0);
					if(rightFace != false){
						rightFace = false;
						GetComponent<Rigidbody2D>().velocity = Vector2.zero;
						
						
						
					}


				}
			}

			//controls backward movement
			if (Input.GetAxis ("Horizontal") != 0) {
				animator.SetBool ("isWalking", true);
				if (Input.GetAxis ("Horizontal") > 0) {
					transform.rotation = Quaternion.Euler (0, 0, 0);
					if(rightFace != true){
						rightFace = true;
						GetComponent<Rigidbody2D>().velocity = Vector2.zero;



					}

				}
			} else {
				animator.SetBool ("isWalking", false);
			}

			if (Input.GetKey (KeyCode.Space)) {

            if(grounded == true)
			

   			Jump();

				/*
				animator.SetBool ("isDead", true);
				print ("You Are Dead!");
				this.enabled = false;
				Application.LoadLevel(Application.loadedLevel);
				*/

			}

			if (Input.GetKey (KeyCode.W) && attacking == false) {
				animator.SetBool ("isWalking", false);
				animator.Play ("Slash_Sword");
				attacking = true;
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			//	Pause ();





			}

		} else if (aCount >= 30) { 

			attacking = false;
			aCount = 0;

		} else {
		
			aCount++;
		
		}


	}


public void Jump(){

    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

}


public void Pause()
	{

	

		/*
		velocity = GetComponent<Rigidbody>().velocity;
		angularVelocity = GetComponent<Rigidbody>().angularVelocity;
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		GetComponent<Rigidbody>().useGravity = false;
		GetComponent<Rigidbody>().isKinematic = true;
		*/

	}

	public void Play()
	{

/*
		GetComponent<Rigidbody>().isKinematic = false; 
		GetComponent<Rigidbody>().velocity = velocity;
		GetComponent<Rigidbody>().angularVelocity = angularVelocity;
		GetComponent<Rigidbody>().useGravity = true;
*/

	}



}
