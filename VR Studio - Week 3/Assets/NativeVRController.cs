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
        leftHand.localPosition = InputTracking.GetLocalPosition(VRNode.LeftHand);
        rightHand.localPosition = InputTracking.GetLocalPosition(VRNode.RightHand);

        leftHand.localRotation = InputTracking.GetLocalRotation(VRNode.LeftHand);
        rightHand.localRotation = InputTracking.GetLocalRotation(VRNode.RightHand);
    }
}
