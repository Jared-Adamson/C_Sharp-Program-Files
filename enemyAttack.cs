using UnityEngine;
using System.Collections;

public class enemyAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D col){
		
		if (col.transform.root != transform.root && col.tag != "Ground" && !col.isTrigger) {
			
			print (col.tag); print ("Enemy Attack Hit");
			if(transform.root && col.tag == "Player"){
				col.transform.root.GetComponentInChildren<Animator>().SetTrigger("isDead");
				col.transform.root.GetComponentInChildren<playerMovement>().enabled = false;
			}
		}
		
	}
}
