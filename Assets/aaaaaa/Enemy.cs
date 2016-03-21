using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
	public float Range = 10;
	public float Speed = 1;
	GameObject Player; 
	
	public static int EnemiesKilled;
	
	
	// Use this for initialization
	void Start () 
	{
		Player = GameObject.Find("First Person Controller");
	}
	
	// Update is called once per frame
	void Update () 
	{
		float distance = Vector3.Distance(transform.position,Player.transform.position);
		
		if (distance < Range)
		{
			FollowPlayer();
			
			if(distance < 2)
			{
				Player.GetComponent<Player>().force += (Player.transform.position - transform.position).normalized * 0.2f;
				Player.GetComponent<Player>().health--;
			}
		}
	}
	
	void FollowPlayer()
	{
		transform.LookAt(Player.transform);
		transform.Translate(Vector3.forward * Time.deltaTime * Speed);
	}
	
	void OnDestroy()
	{
		EnemiesKilled++;
	}
}
