using UnityEngine;
using System.Collections;

public class switchtotemple : MonoBehaviour {

	void OnTriggerEnter ()
	{
		Application.LoadLevel ("temple");
	}
}
