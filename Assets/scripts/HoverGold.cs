using UnityEngine;
using System.Collections;

public class HoverGold : MonoBehaviour {

	public float turnSpeed = 5f;
	public float hoverForce = 65f;
	public float hoverHeight = 10f;
	private Rigidbody goldRigidbody;
	
	
	void Awake () 
	{
		goldRigidbody = GetComponent <Rigidbody>();
	}
	
	void FixedUpdate()
	{
		Ray ray = new Ray (transform.position, -transform.up);
		RaycastHit hit;
		
		if (Physics.Raycast(ray, out hit, hoverHeight))
		{
			float proportionalHeight = (hoverHeight - hit.distance) / hoverHeight;
			Vector3 appliedHoverForce = Vector3.up * proportionalHeight * hoverForce;
			goldRigidbody.AddForce(appliedHoverForce, ForceMode.Acceleration);
		}

		goldRigidbody.AddRelativeTorque(0f, turnSpeed, 0f);
		
	}
}