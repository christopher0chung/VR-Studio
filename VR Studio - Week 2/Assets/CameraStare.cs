using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStare : MonoBehaviour {

    RaycastHit myHit;

    void FixedUpdate ()
    {
        Ray myRay = new Ray(transform.position, transform.forward);
        Physics.Raycast(myRay, out myHit, Mathf.Infinity);

        if (myHit.collider.gameObject.GetComponent<IStareable>() != null)
        {
            myHit.collider.gameObject.GetComponent<IStareable>().StareAt(Time.fixedDeltaTime);
        }

        Debug.DrawLine(transform.position, transform.forward * Mathf.Infinity);
	}
}
