using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rb;

    public Transform target;
    public float speed;
    public float amplitude; //amplitude of vibration
    public float frequency;// frequency of vibration

    private float startTime;
    public float degreesPerSecond = 1.5f;
    private Vector3 direction;
    private Vector3 orthogonal;

    void Start()
    {
        startTime = Time.time;
        direction = (target.position - transform.position).normalized;//calculating direction of target in which GO must travel (target - transform) and normalizing it to a 
                                                                        //value of 1 i.e start is 0 and ending at target is 1
        orthogonal = new Vector3(-direction.z, 0, direction.x); //Moving the lantern Orthogonally from -Z to +X, this simulates wind motion
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
    }

    void FixedUpdate()
    {
        float t = Time.time - startTime;
        rb.velocity = direction * speed + orthogonal * amplitude * Mathf.Sin(frequency * t);
    }
}