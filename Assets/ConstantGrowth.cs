using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantGrowth : MonoBehaviour {

    public float TimeToGrow = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        TimeToGrow = +Time.deltaTime;

        transform.localScale += new Vector3(TimeToGrow / 6000f, TimeToGrow / 6000, TimeToGrow / 6000);

    }
}
