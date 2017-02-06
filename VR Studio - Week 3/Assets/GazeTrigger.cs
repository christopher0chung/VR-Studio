using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 camLookDir = Camera.main.transform.forward;
        Vector3 vectorFromCameraToTarget = transform.position - Camera.main.transform.position;

        float angle = Vector3.Angle(camLookDir, vectorFromCameraToTarget);

        //Can do something based off of angle.
        if (angle <= 15f)
        {
            transform.localScale *= 1.01f;
        }

    }
}
