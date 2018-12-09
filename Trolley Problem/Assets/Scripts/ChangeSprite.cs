using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {
	public Sprite bloodSprite;
    public int order;

    

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void changeSprite () {
        GetComponent<SpriteRenderer>().sprite = bloodSprite;
        GetComponent<SpriteRenderer>().sortingOrder = order; 
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        changeSprite();
    }

    // void OnCollisionEnter(Collider c)
    // {
    //     Debug.Log("OnCollisionEnter");
    //     changeSprite();
    // }
}
