using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolMovement : MonoBehaviour {

    public float speed;

    [SerializeField]
    Vector3 dirBase;

    private float timer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        timer += Time.fixedDeltaTime;

        if (timer < 10)
        {
            transform.eulerAngles = Vector3.zero;
            transform.position += Vector3.Normalize(dirBase) * speed;
        }

        else if (timer > 20)
            timer -= 20;

        else
        {
            transform.eulerAngles = Vector3.up * 180;
            transform.position -= Vector3.Normalize(dirBase) * speed;
        }

    }
}
