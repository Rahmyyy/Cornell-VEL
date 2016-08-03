﻿using UnityEngine;
using System.Collections;

public class StartClicked : InputOuput {
	private GameObject start_menu; 
	public GameObject leftModel;
	public GameObject rightModel; 

	//The chosen controller becomes the parent of the respective chosen model
	public void ChangeParent() {
		firstOutDropResult.transform.parent = firstInpDropResult.transform;
		secondOutDropResult.transform.parent = secondInpDropResult.transform;

		if (firstOutDropResult == leftFoot || secondOutDropResult == leftFoot) {
			FootChosen (leftHand);
			leftFoot.GetComponent<FootMovement> ().enabled = false;
			leftModel.SetActive (false); 
		}

		if (firstOutDropResult == rightFoot || secondOutDropResult == rightFoot) {
			FootChosen (rightHand); 
			rightFoot.GetComponent<FootMovement> ().enabled = false;
			rightModel.SetActive (false); 
		} 

		start_menu = GameObject.Find ("/StartMenu");
		start_menu.SetActive (false);
	}

	public void FootChosen(GameObject correspondingArm){
		correspondingArm.SetActive (false);
	}    
}