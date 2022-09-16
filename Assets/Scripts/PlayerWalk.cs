﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int PlayerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton ("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * PlayerSpeed * Time.deltaTime;
        }

    }
}
