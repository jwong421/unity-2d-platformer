﻿using UnityEngine;
using System.Collections;

public class A3_DirectionActivate : MonoBehaviour {

	public TextAsset text;

	public int startLine;
	public int endLine;
	public bool colii;


	public A3_DirectionManager manager;

	// Use this for initialization
	void Start () {

		manager = FindObjectOfType<A3_DirectionManager> ();
		colii = false;

	}

	public void OnTriggerStay2D (Collider2D col){

		if(col.tag == "Player") {
			colii = true;	

			manager.ReloadScript (text);
			manager.currentLine = startLine;
			manager.endAtLine = endLine;
			manager.EnableTextBox ();

		}

	}

	void OnTriggerExit2D(Collider2D col) {

		colii = false;	

		manager.DisableTextBox ();
	}

}