using UnityEngine;
using System.Collections;

	public class FastCamra2d : MonoBehaviour
	{
		public Transform target;
		public float smoothness;
		private Vector3 targetInitialPos;
		void Awake ()
		{
			targetInitialPos = target.position;
		}
		void Update ()
		{
			Vector3 cameraPosition = target.position - targetInitialPos;
		cameraPosition.y = 0.5f;
			cameraPosition.z = -10f;
			transform.position = cameraPosition;
			//        transform.position = Vector3.Lerp (transform.position , cameraPosition , Time.deltaTime * smoothness);
		}
	}