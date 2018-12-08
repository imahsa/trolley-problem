using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSwitch : MonoBehaviour {

    Animator animator;
	
	public SpriteRenderer leftHighlighted;
	public SpriteRenderer rightHighlighted;


    // Use this for initialization
    void Start () {
		animator = GetComponent<Animator>();
        leftHighlighted.enabled = true;
		rightHighlighted.enabled = false;
	}

	public void setSwitch () {
		bool currentState = animator.GetBool("isSwitchEnabled");
		animator.SetBool("isSwitchEnabled", !currentState);
        leftHighlighted.enabled = !leftHighlighted.enabled;
        rightHighlighted.enabled = !rightHighlighted.enabled;
	}
}
