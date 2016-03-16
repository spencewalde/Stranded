using UnityEngine;
using System.Collections;

public class switchtojungle : MonoBehaviour {

	void OnTriggerEnter ()
	{
		Application.LoadLevel("JungleScene");
	}
}

