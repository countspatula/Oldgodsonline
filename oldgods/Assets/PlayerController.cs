using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 0.15f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("LeftX"),0,0)*speed;
        transform.position += new Vector3(0,Input.GetAxis("LeftY"), 0)*speed;
        if (Input.GetAxis("RightX") != 0.0f || Input.GetAxis("RightY") != 0.0f) {
            Vector3 direction = new Vector3(Input.GetAxis("RightX"), 0, Input.GetAxis("RightY"));
            transform.rotation = Quaternion.Euler(new Vector3( Mathf.Atan2(direction.y, direction.x), transform.rotation.y, transform.rotation.z));
         
    }
}
}
