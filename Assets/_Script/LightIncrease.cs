using UnityEngine;
using System.Collections;

public class LightIncrease : MonoBehaviour


{
    public Light FireLight;
    public float minIntensity = 3.5f;
    public float maxIntensity = 4.5f;

    float random;

    void Start()
    {
        random = Random.Range(0.0f, 65535.0f);
    }
     
    void Update()
    {
        float noise = Mathf.PerlinNoise(random, Time.time);
        FireLight.intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}
