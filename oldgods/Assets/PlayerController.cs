using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 0.15f;
    public GameObject Arrow;
    public float spread = 30;
    float nextShot;
    float shotCooldown = 0.5f;
	// Use this for initialization
	void Start () {
        nextShot = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetAxis("Fire1") <= -0.5f&&Time.time>nextShot||Input.GetAxis("LeftBumper")<=-0.5f)
        {

          GameObject arrow=  (GameObject)Instantiate(Arrow);
          arrow.transform.parent = this.transform.parent;
          arrow.transform.position = this.transform.position;
          arrow.transform.eulerAngles = this.transform.eulerAngles + Random.onUnitSphere*spread;
          nextShot = Time.time + shotCooldown;
        }
       

	}
    void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("LeftX"),0,0)*speed;
        transform.position += new Vector3(0,Input.GetAxis("LeftY"), 0)*speed;

        if (Input.GetAxis("RightY") != 0 || Input.GetAxis("RightX") != 0) { 
      //  transform.rotation = Quaternion.Euler( 90, 0,Mathf.Atan2(Input.GetAxis("RightY"), Input.GetAxis("RightX")) * Mathf.Rad2Deg+90);
      transform.rotation=Quaternion.AngleAxis(Mathf.Atan2(Input.GetAxis("RightY"), Input.GetAxis("RightX"))*Mathf.Rad2Deg-90, new Vector3(0, 0, 1));
         
    }
}
    void LateUpdate() 
 {
     Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
       
 }
}
