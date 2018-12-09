using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSwitch : MonoBehaviour {

    Animator animator;
	
	public GameObject leftHighlighted;
	public GameObject rightHighlighted;


    // Use this for initialization
    void Start () {
		animator = GetComponent<Animator>();
        leftHighlighted.SetActive(true);
		rightHighlighted.SetActive(false);
	}

	public void setSwitch () {
		bool currentState = animator.GetBool("isSwitchEnabled");
		animator.SetBool("isSwitchEnabled", !currentState);
        leftHighlighted.SetActive(!leftHighlighted.activeSelf); 
        rightHighlighted.SetActive(!rightHighlighted.activeSelf);
	}
}
