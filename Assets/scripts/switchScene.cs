using UnityEngine;
using System.Collections;

public class switchScene: MonoBehaviour {

	void OnTriggerEnter ()
	{
		Application.LoadLevel ("cave");
	}
}
