using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	AudioSource trainLoop;
	// Use this for initialization
	void Start () {
        trainLoop = GetComponent<AudioSource>();
	}
	
	void StopTrainLoop () {
		trainLoop.Stop();
	}
}
