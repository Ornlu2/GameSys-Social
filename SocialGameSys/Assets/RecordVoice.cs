using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordVoice : MonoBehaviour {

    AudioSource aud;

    // Use this for initialization
    void Start () {
         aud = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		

        if(Input.GetKeyDown(KeyCode.Space))
        {
            aud.clip = Microphone.Start("Microphone", true, 200, 44100);
            aud.PlayDelayed(0.25f);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            aud.Pause();
        }

	}
}
