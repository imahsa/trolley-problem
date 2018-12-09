using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerAudio : MonoBehaviour {

	public AudioSource [] audioSources;
	// Use this for initialization
	public void playAllAudio() {
		foreach(var item in audioSources) {
            item.Play();
		}
	}
}
