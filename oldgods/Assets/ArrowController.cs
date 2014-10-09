using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {

    Animator anim;
    float speed = 3.0f;
	// Use this for initialization
	void Start () {
        anim  = GetComponent<Animator>();
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.up * (speed / 20.0f);
        anim.speed = speed;
    }
    void OnCollisionEnter(Collision collision)
    {
       
        speed = 0;
        anim.speed = 0;
        this.transform.parent.parent = collision.gameObject.transform;
        this.collider.enabled = false;
        this.enabled = false;
        anim.enabled = false;
     
      
    }
}
