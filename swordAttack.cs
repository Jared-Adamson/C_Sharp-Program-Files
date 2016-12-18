using UnityEngine;
using System.Collections;

public class swordAttack : MonoBehaviour {

	GameObject deathID;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D col){

		if (col.transform.root != transform.root && col.tag != "Ground" && !col.isTrigger) {
		
			print (col.tag); print ("Attack Hit");
			if(transform.root && col.tag == "Enemy"){
			col.transform.root.GetComponentInChildren<Animator>().SetTrigger("Dead");
			col.transform.root.GetComponentInChildren<EnemyAI>().enabled = false;
			StartCoroutine(Example());
			deathID = col.gameObject;
			
			}
		
		}

	}

	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(3);
		Destroy(deathID);
	}
}
