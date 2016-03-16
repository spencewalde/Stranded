using UnityEngine;
using System.Collections;

public class cavetomainmap: MonoBehaviour {

	void OnTriggerEnter ()
	{
		Application.LoadLevel ("Mainisland");
	}
}
