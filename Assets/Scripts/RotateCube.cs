using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float SpinForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate (0, SpinForce * Time.deltaTime, 0); 

    }

    public void ChangeSpin()
    {
        SpinForce = -SpinForce;
    }
}
