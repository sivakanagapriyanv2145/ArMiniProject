﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScriptC2 : MonoBehaviour,IVirtualButtonEventHandler {

    private GameObject vbButtonObject;
    public AudioClip MusicClip;
    public AudioSource MusicSource;

	// Use this for initialization
	void Start () {

        vbButtonObject = GameObject.Find("C2Note");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        MusicSource.clip = MusicClip;
		
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {

        Debug.Log("Button down");
        MusicSource.Play();


    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {

        Debug.Log("Button up");

    }
	
}
