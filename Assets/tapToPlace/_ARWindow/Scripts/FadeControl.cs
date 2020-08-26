using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeControl : MonoBehaviour
{
    public Material fadeMat;
    public float dist, fadeAmount; 
    public float near, far;
    public Camera cam;
    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        dist = Vector3.Distance(this.transform.position, cam.transform.position);

        // if(dist>near && dist<far){
            fadeAmount = Mathf.Clamp(dist-near, -0.1f, 1.1f);
            fadeMat.SetFloat("_FadeBetween", fadeAmount);
        // }
        // fadeMat.SetFloat("_FadeBetween", fadeAmount);
    }
}
