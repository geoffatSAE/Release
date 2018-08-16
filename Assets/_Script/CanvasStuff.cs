using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStuff : MonoBehaviour {

    public GameObject canvasEGO;
    public GameObject canvas;
    public AudioSource listener;
    public AudioClip music;


    // Use this for initialization
    void Start () {

        canvasEGO.GetComponent<BoxCollider>();
        canvas.GetComponent<UIFaderIn>();
        listener = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {


        canvasEGO.GetComponent<BoxCollider>().enabled = false;
        canvas.GetComponent<UIFaderIn>().enabled = true;
        listener.GetComponent<AudioSource>().enabled = true;
        listener.PlayOneShot(music);
    }
}
