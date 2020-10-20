﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour {
	public AudioClip sesEfekti;
	private GameObject top;
	
	void Start () {
		top = GameObject.Find ("top");
	}
	void Update () {
		Vector3 farePos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
		transform.position = new Vector3 (Mathf.Clamp(farePos.x,-3f,3f), transform.position.y, transform.position.z);
		//transform.position=new Vector3(top.transform.position.x,transform.position.y,transform.position.z);
	}

	void OnCollisionEnter2D(Collision2D diger){
		AudioSource.PlayClipAtPoint (sesEfekti, transform.position);
	}
}
