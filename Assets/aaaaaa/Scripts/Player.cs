using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject bullet; 
	public float forceDecrease = 2;
	public float health = 10;
	
	[HideInInspector]
	public Vector3 force;
	
	
	// Use this for initialization
	void Start () 
	{
		Cursor.visible = false;
		Enemy.EnemiesKilled = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(health <= 0)
		{
			Application.LoadLevel(1);
		}
		
		
		if(Input.GetMouseButtonDown(0))
		{
			AudioHandler.Instance.PlaySound(AudioHandler.Instance.Shoot);
			Instantiate(bullet,GameObject.Find("StartProjectil").transform.position, GameObject.Find ("StartProjectil").transform.rotation);
		}
		
		if(Input.GetMouseButtonDown(1))
		{
		GameObject.Find("Flamethrower").GetComponent<ParticleSystem>().Play();
		}
		
		
		if(Input.GetMouseButtonUp(1))
		{
		GameObject.Find("Flamethrower").GetComponent<ParticleSystem>().Stop();
		}
		
		GetComponent<CharacterController>().Move(force * Time.deltaTime);
		
		if(force.x > 0)
			force.x = Mathf.Max(0, force.x - forceDecrease * Time.deltaTime);
		else if (force.x < 0)
			force.x = Mathf.Min(0,force.x + forceDecrease * Time.deltaTime);
		
		if(force.y > 0)
			force.y = Mathf.Max(0, force.y - forceDecrease * Time.deltaTime);
		else if (force.y < 0)
			force.y = Mathf.Min(0,force.y + forceDecrease * Time.deltaTime);
		
		if(force.z > 0)
			force.z = Mathf.Max(0, force.z - forceDecrease * Time.deltaTime);
		else if (force.z < 0)
			force.z = Mathf.Min(0,force.z + forceDecrease * Time.deltaTime);
	}
	
	void OnGUI()
	{
		GUI.Box(new Rect(0,0,100,30), "Health: " + Mathf.Max (0, health).ToString());
		GUI.Box(new Rect(0,30,100,30), "Kill Counter: " + Enemy.EnemiesKilled.ToString());
	}
	
}
