﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// to access Unity's VR functions, add the namespace
using UnityEngine.VR;

public class MouseLook : MonoBehaviour {

	void Start () {
		// are we using VR
        if (VRDevice.isPresent)
            Debug.Log("VR is enabled" + VRDevice.model);
	}
	
	void Update () {
        if (VRDevice.isPresent)
            return;
        else
        {
            // mouseLook code
            var myCam = Camera.main.transform;
            // rotate camera based on mouse speed
            myCam.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);

            // unroll camera
            myCam.localEulerAngles = new Vector3(myCam.localEulerAngles.x, myCam.localEulerAngles.y, 0f);
        }
	}
}
