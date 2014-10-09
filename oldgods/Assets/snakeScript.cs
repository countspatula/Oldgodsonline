using UnityEngine;
using System.Collections;

public class snakeScript : MonoBehaviour {
	public GameObject segment;
	public GameObject Plating;
	public float gap = 6.0f;
	public int segmentAmounts = 2;
	public float radius = 7.0f;
	// Use this for initialization
	void Start () {
		//idleGap = transform.position.y;
		float temp = transform.position.y;
		GameObject prevObj = new GameObject();
		Vector3 scaleIncrement = new Vector3();
		for(int i = 0; i < segmentAmounts; i++)
		{
			temp += gap;
			GameObject newtempObj = Instantiate (segment, new Vector3 (transform.position.x, temp, transform.position.z), Quaternion.identity) as GameObject;
			var tempComp = newtempObj.AddComponent<follow>();
			if(i == 0)
			{
				tempComp.target = this.gameObject;
				prevObj = newtempObj;
				scaleIncrement = prevObj.transform.localScale;
				continue;
			}
			newtempObj.transform.localScale = scaleIncrement;
			tempComp.target = prevObj;
			prevObj = newtempObj;
			scaleIncrement *= 0.99f;
			if(i%3 == 0)
			{
				Instantiate (Plating, new Vector3 (transform.position.x, temp, transform.position.z), Quaternion.identity);
			}
		}
	}
	// Update is called once per frame
	void FixedUpdate () {

//		float x = radius * Mathf.Cos (angle);
//		float y = radius * Mathf.Sin (angle);
//		transform.position = new Vector3 (x, y, transform.position.z);
//		angle += 0.1f;
	}
	
}
