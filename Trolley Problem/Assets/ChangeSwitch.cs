using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSwitch : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	public void setSwitch () {
		bool currentState = animator.GetBool("isSwitchEnabled");
		animator.SetBool("isSwitchEnabled", !currentState);
	}
}
