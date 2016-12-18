using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{

	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 1f;
	//Vector3 look = new Vector3(0,0,0);
	//Vector3 me = new Vector3(0,0,0);
	bool grnd;
	public float rotationSpeed=10f;
	float someScale;
	
	
	void Start () {
		//target = 
		grnd = target.GetComponent<playerMovement> ().grounded;
		someScale = transform.localScale.x; 
	}
	
	void FixedUpdate(){

		target = GameObject.FindWithTag ("Player").transform;
		
		//rotate to look at the player
		//look = target.position;
		//look.y = me.y;
		//grnd = target.GetComponent<playerMovement> ().grounded;
		//transform.LookAt(look);
		//transform.Rotate(new Vector3(0,0,0),Space.Self);//correcting the original rotation
		//rotate to look at the player
	//	if (grnd == true) {

	//		transform.Rotate (new Vector3 (0, -90, 0), Space.Self);//correcting the original rotation
	//	}


		//rotate to look at the player
		//transform.LookAt(target.position);
		//transform.Rotate(new Vector3(0,-90,0),Space.Self);//correcting the original rotation

		if(transform.position.x < target.position.x)
			transform.rotation = Quaternion.Euler (0, 0, 0);

		if(transform.position.x > target.position.x)
			transform.rotation = Quaternion.Euler (0, 180, 0);


		//move towards the player
		if (Vector3.Distance(transform.position,target.position)>2f){//move if distance from target is greater than 1
			transform.Translate(new Vector3(speed*Time.deltaTime,0,0) );
		}
		
	}


}

    

