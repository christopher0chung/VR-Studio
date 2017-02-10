using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SchoolMovement : MonoBehaviour {

    private float distance;
    private Vector3 targetPos;
    private float speed = .1f;

    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
        distance = Vector3.Distance(transform.position, targetPos);

        if (distance <= 1)
        {
            transform.Rotate(Vector3.up * .5f);
        }

    }

    public void MoveToTarget()
    {
        targetPos = GameObject.Find("Target").transform.position;
    }
}
