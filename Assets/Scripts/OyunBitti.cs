using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour {
	public UnityEngine.UI.Text puan;
	
	void Start () {
		
		puan.text = "Puanınız:"+GameObject.FindObjectOfType<Puan> ().GetComponent<Puan> ().PuaniAl();
	}
	
	public void AnaSahneyeGec(){
		SceneManager.LoadScene (0);
	}
}
