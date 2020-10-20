using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanMuzigi : MonoBehaviour {
	 static bool SahnedeMuzikVar;
	
	void Awake () {
		if (!SahnedeMuzikVar) {
			GameObject.DontDestroyOnLoad (gameObject);
			SahnedeMuzikVar = true;
		} else{
			Destroy (gameObject);
		}
	}
}
