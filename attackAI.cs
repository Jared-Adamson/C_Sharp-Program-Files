using UnityEngine;
using System.Collections;

public class attackAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D col){
		
		if (col.transform.root != transform.root && col.tag != "Ground" && !col.isTrigger) {
			
			print (col.tag); print ("In Hit Box");
			if(transform.root && col.tag == "Player")
				GetComponentInChildren<Animator>().SetTrigger("Attack");

			
		}
		
	}

	void OnTriggerExit2D(Collider2D col){
		
		if (col.transform.root != transform.root && col.tag != "Ground" && !col.isTrigger) {
			
			print (col.tag); print ("Left Hit Box");

			GetComponentInChildren<Animator>().SetBool ("Attack", false);
			
			
		}
		
	}


}
