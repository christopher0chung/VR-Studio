using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRepresentation : MonoBehaviour {

    public Transform thingToTrack;
    public Transform myHead;

    //public void Init(Transform reference, Transform head)
    //{
    //    thingToTrack = reference;
    //    myHead = head;
    //}

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (thingToTrack != null)
        {
            transform.position = myHead.transform.position + ((thingToTrack.transform.position - myHead.transform.position) * 150f);
        }

        if (gameObject.name == "RHSphere")
        {
            GameObject.Find("SchoolRH").GetComponent<SchoolMovement>().MoveToTarget(transform.position);
        }
        else if (gameObject.name == "LHSphere")
        {
            GameObject.Find("SchoolLH").GetComponent<SchoolMovement>().MoveToTarget(transform.position);
        }
    }
}
