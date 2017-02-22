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
	void Update () {

        distance = Vector3.Distance(transform.position, targetPos);
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * 60 * Time.deltaTime);

        if (distance <= 1)
        {
            transform.Rotate(Vector3.up * .5f * 60 * Time.deltaTime);
            if (transform.eulerAngles.y > 360)
            {
                transform.eulerAngles = new Vector3((transform.eulerAngles.x + 360) % 360, (transform.eulerAngles.y + 360) % 360, (transform.eulerAngles.z + 360) % 360);
            }
        }
        else
        {
            transform.Rotate(Vector3.right * .1f * 60 * Time.deltaTime);
        }

    }

    public void MoveToTarget(Vector3 loc)
    {
        targetPos = loc;
    }
}
