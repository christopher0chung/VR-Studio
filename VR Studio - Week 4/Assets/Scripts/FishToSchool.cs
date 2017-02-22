using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class FishToSchool : MonoBehaviour {

    private Transform school;

    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    [SerializeField] private float offsetZ;

    public float fishSpeed;

    private Vector3 lastPos;
    private Vector3 dir;

    private bool switcher;

	// Use this for initialization
	void Start () {

        school = GameObject.Find("School").transform;

        offsetX = transform.position.x - school.position.x;
        offsetY = transform.position.y - school.position.y;
        offsetZ = transform.position.z - school.position.z;

        int randSeed = Random.Range(0, 1);
        if (randSeed == 0)
        {
            switcher = true;
        }
        else
        {
            switcher = false;
        }
	}
	
	// Update is called once per frame
	void Update () {

        switcher = !switcher;

        lastPos = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, school.position + (school.right * offsetX) + (school.up * offsetY) + (school.forward * offsetZ), fishSpeed * 60 * Time.deltaTime);

        if (switcher)
        {
            dir = Vector3.Normalize(transform.position - lastPos);
            if (dir != Vector3.zero)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir, Vector3.up), .09f);
            }
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir, Vector3.up), .09f);

        }
    }
}
