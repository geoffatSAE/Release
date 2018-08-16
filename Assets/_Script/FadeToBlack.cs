using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToBlack : MonoBehaviour
{

    Renderer r;

    // Use this for initialization
    void Start()
    {
        r = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine("ToBlack");

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine("FromBlack");

        }

    }

    IEnumerator FromBlack()
    {
        for (float f = 1f; f >= 0; f -= 0.01f)
        {
            Color c = r.material.color;
            c.a = f;
            r.material.color = c;
            yield return null;
        }
    }


    IEnumerator ToBlack()
    {
        for (float f = 0f; f <= 1; f += 0.01f)
        {
            Color c = r.material.color;
            c.a = f;
            r.material.color = c;
            yield return null;
        }
    }
}