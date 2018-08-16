using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSeconds : MonoBehaviour {
    private float v;

    public WaitForSeconds(float v)
    {
        this.v = v;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(10f);
    }
}
