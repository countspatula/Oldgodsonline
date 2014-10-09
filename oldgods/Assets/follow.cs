using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	// Params
	float moveSpeed = 9.0f; // Move speed
	float rotationSpeed = 20.0f; // Speed of turning   

	public GameObject target;
	//public GameObject Cube2;

	void FixedUpdate () 
	{
		// Vector from cube pos to player pos (vector math: target - position = vector to target from pos)
		var dir = target.transform.position - this.transform.position;
		
		// If the distance is over 5 units
		if(dir.magnitude > 0.4f)
		{
			// Rotate towards player
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(dir), rotationSpeed * Time.deltaTime);
			
			// Move forward at specified speed
			this.transform.position += this.transform.forward * moveSpeed * Time.deltaTime;
		}
	}
}
