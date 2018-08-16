using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.Events;

[RequireComponent(typeof(VRInteractiveItem))]
public class VRItemEvenHandler : MonoBehaviour {

    private VRInteractiveItem interactiveItem;
    public UnityEvent GazeEnterEvent;
    public UnityEvent GazeExitEvent;

	// Use this for initialization
	void Start () {
        interactiveItem = GetComponent<VRInteractiveItem>();
        interactiveItem.OnOver += OnGazeEnter;
        interactiveItem.OnOut += OnGazeExit;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGazeEnter()
    {
        GazeEnterEvent.Invoke();
    }

    void OnGazeExit()
    {
        GazeExitEvent.Invoke();
    }

}
