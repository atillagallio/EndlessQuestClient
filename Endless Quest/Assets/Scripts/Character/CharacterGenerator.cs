using System;
using UnityEngine;

public class CharacterGenerator : MonoBehaviour{
	private PlayerCharacter _toon;	

	void Start (){
		_toon = new PlayerCharacter ();
	}

	void Update (){
	}

	void OnGUI(){
		GUI.Label (new Rect (10, 10, 50, 25), "Name:");
		_toon.name = GUI.TextArea (new Rect (), _toon.name);
	}
}

