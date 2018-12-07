using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {
	public Sprite bloodSprite;

    

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void changeSprite () {
        GetComponent<SpriteRenderer>().sprite = bloodSprite;
	}

    void OnTriggerEnter2D(Collider2D c)
    {
		Debug.Log("OnTriggerEnter");
        changeSprite();
    }

    // void OnCollisionEnter(Collider c)
    // {
    //     Debug.Log("OnCollisionEnter");
    //     changeSprite();
    // }
}
