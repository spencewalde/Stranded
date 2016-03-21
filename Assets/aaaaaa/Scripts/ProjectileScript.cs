using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {
	
	public float speed; 
	Vector3 dir;
	
	
	// Use this for initialization
	void Start () 
	{
		Cursor.visible = false;
		dir = Camera.main.transform.forward;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(dir * speed * Time.deltaTime, Space.World);
	}
	
	void OnTriggerEnter(Collider otherObject)
	{
		if(otherObject.name == "Bob")
		{
			Destroy(otherObject.gameObject);
		}
		if(otherObject.name == "Boss")
		{
			Destroy(otherObject.gameObject);
		}
	}
				
	
}
