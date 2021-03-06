﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class A2_DirectionManager : MonoBehaviour {

	public GameObject textbox;

	public Text text;

	public TextAsset textfile;
	public string[] textlines;

	public int currentLine;
	public int endAtLine;

	public A2_PlayerConroller player;

	//Use this for initialization
	void Start () {

		player = FindObjectOfType<A2_PlayerConroller>();

		if(textfile != null){

			textlines = (textfile.text.Split('\n'));
		}

		if (endAtLine == 0){

			endAtLine = textlines.Length - 1;

		}

	}

	void Update() {

		text.text = textlines [currentLine];

		if (currentLine > endAtLine) {

			DisableTextBox ();
		}
	}

	//Enables Text Box
	public void EnableTextBox() {

		textbox.SetActive (true);

	}

	//Disables/Closes text box
	public void DisableTextBox() {

		textbox.SetActive (false);

	}

	public void ReloadScript(TextAsset text) {

		if (text != null) {

			textlines = new string[1];
			textlines = (text.text.Split('\n'));
		}
	}

}