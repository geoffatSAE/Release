using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameFlicker : MonoBehaviour {

    private Light fireLight;
    private Color originalColor;
    private float timePassed;
    private float changeValue;

	
	void Start () {
        //storing light component to variable
        fireLight = this.GetComponent<Light>();


        if(fireLight != null)
        {
            originalColor = fireLight.color;
        }
        else
        {
            enabled = false;
            return;
        }

        changeValue = 0;
        timePassed = 0;
	}
	

	void Update ()
    {
        timePassed = Time.time;

        //normalising value to between 0 and 1
        timePassed = timePassed - Mathf.Floor(timePassed);

        fireLight.color = originalColor * CalculateChange();
		
	}

    private float CalculateChange()
    {
        //creates fluctuation between frequency, pulse and intensity
        changeValue = -Mathf.Sin(timePassed * 2 * Mathf.PI) * 0.004f + 0.40f;
        return changeValue;
    }
}
