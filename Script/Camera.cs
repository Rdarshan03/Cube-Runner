using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Camera : MonoBehaviour
{
    public Transform target;
    private float smoothtime;
    private Vector3 currentvelocity = Vector3.zero;
    private Vector3 offset;

    public Light light;

    private void Start()
    {
        light.intensity = 3f;
    }

    private void Awake()
    {
        offset = transform.position - target.position;
    }
    private void Update()
    {
        Vector3 targetposition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref currentvelocity, smoothtime);
    }
}
