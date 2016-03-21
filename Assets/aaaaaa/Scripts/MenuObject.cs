using UnityEngine;
using System.Collections;

public class MenuObject : MonoBehaviour 
{
	public bool isQuit = false;
	public bool isOptions = false;
	public bool isHelp = false;
	public bool isCredit = false;
	public bool isBack = false;
	
	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.white;
	}
	
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = Color.red;
	}
	
	void OnMouseDown()
	{
		if(isQuit)
		{
			Application.Quit();
		}
		else 
		{
			Application.LoadLevel(1);
		}
		if(isOptions)
		{
			Application.LoadLevel(2);
		}
		if(isHelp)
		{
			Application.LoadLevel(3);
		}
		if(isCredit)
		{
			Application.LoadLevel(4);
		}
		if(isBack)
		{
			Application.LoadLevel(0);
		}
	}
}
