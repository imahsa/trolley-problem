using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventListener : MonoBehaviour {
Animator animator;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		 if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Start");
        }
	}
}
