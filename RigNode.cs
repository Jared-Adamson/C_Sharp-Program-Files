using UnityEngine;
using System.Collections;

public class RigNode : MonoBehaviour {
	public Color lineColor = Color.red;

	void OnDrawGizmos()
	{
		Gizmos.color = lineColor;
		Vector3 parentPos = transform.parent.position;
		if(transform.parent != null) // ignore if no parent (stage top level)
		{
			Gizmos.DrawLine(transform.position,parentPos);
		}
	}

}
