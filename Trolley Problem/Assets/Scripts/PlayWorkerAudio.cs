using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWorkerAudio : MonoBehaviour {

	public GameObject worker;
	
	void playWorkerAudio () {
		WorkerAudio audio = worker.GetComponent<WorkerAudio>();
        audio.playAllAudio();
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        playWorkerAudio();
    }
}
