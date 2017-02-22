using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR;

public class BasicPickup : MonoBehaviour {

    [SerializeField] private SteamVR_ControllerManager myCM;
    [SerializeField] private Rigidbody myHeldRB;

    SteamVR_Controller.Device myDevice
    {
        get
        {
            return SteamVR_Controller.Input((int)GetComponent<SteamVR_TrackedObject>().index);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (myHeldRB != null && !myDevice.GetHairTrigger())
        {
            myHeldRB.isKinematic = false;
            myHeldRB.transform.SetParent(null);
            myHeldRB = null;
        }

		
	}

    void OnTriggerStay(Collider other)
    {
        if (myDevice.GetHairTrigger())
        {
            myHeldRB = other.GetComponent<Rigidbody>();
            myHeldRB.isKinematic = true;
            myHeldRB.transform.SetParent(this.transform);
        }
    }
}
