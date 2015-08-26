using UnityEngine;
using System.Collections;

public class RobotFollowCamera : MonoBehaviour {

	public float xOffset = 20;
	public float yOffset = 50;
	public float zOffset = 0;
		
	void LateUpdate() {
		GameObject target = GameObject.Find("Robot");
		this.transform.position = new Vector3(target.transform.position.x + xOffset,
		                                      target.transform.position.y + yOffset,
		                                      target.transform.position.z + zOffset);
	}

}
