using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.DrawRay(transform.position, transform.forward * 100, Color.green);
		
		RaycastHit hitInfo;
		
		if(Physics.Raycast(transform.position,transform.forward * 100,out hitInfo))
		{
			if(Input.GetMouseButton(0))
			{
				switch(hitInfo.collider.name)
				{
					case "Start Game Text":
						Application.LoadLevel(1);
						break;
				case "quit game text":
					Application.Quit();
					break;
				}
			}
		}
	}
}
