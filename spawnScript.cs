using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	int spn;


	public GameObject badguy;
	// Use this for initialization
	void Start () {

		spn = 0;


	
	}
	
	// Update is called once per frame
	void Update () {

		spn = Random.Range (0, 200);

		if (spn == 100)
			Instantiate (badguy, transform.position, transform.rotation);
	
	}
}
