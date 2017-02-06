using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// to access Unity's VR functions, add the namespace
using UnityEngine.VR;

public class MouseLook : MonoBehaviour {

    public float mouseSpeedScale;

	void Start () {
        // are we using VR
        if (VRDevice.isPresent)
            Debug.Log("VR is enabled" + VRDevice.model);
        else
            transform.position = new Vector3(0, 2, 0);

        // 50% is useable
        // 10% is drastic
        //VRSettings.renderScale = .5f;

        // when false, there is no preview
        VRSettings.showDeviceView = true;

        // another special function for performance
        // VRStats.gpuTimeLastFrame
	}
	
	void Update () {
        if (VRDevice.isPresent)
            return;
        else
        {
            // mouseLook code
            var myCam = Camera.main.transform;
            // rotate camera based on mouse speed
            myCam.Rotate(-Input.GetAxis("Mouse Y") * mouseSpeedScale, Input.GetAxis("Mouse X") * mouseSpeedScale, 0f);
            // unroll camera
            myCam.localEulerAngles = new Vector3(myCam.localEulerAngles.x, myCam.localEulerAngles.y, 0f);
        }
	}

    private void GazeEmitter()
    {

    }
}
