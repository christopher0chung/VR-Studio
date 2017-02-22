using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePivot : MonoBehaviour {

    [SerializeField]
    private float rotSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

	}
}
