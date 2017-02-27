using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.VR;

public class NativeVRController : MonoBehaviour {

    public Transform leftHand, rightHand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        leftHand.position = InputTracking.GetLocalPosition(VRNode.LeftHand);
        rightHand.position = InputTracking.GetLocalPosition(VRNode.RightHand);

        leftHand.rotation = InputTracking.GetLocalRotation(VRNode.LeftHand);
        rightHand.rotation = InputTracking.GetLocalRotation(VRNode.RightHand);
    }
}
