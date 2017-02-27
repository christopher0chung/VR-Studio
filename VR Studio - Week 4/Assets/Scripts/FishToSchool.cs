using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class FishToSchool : MonoBehaviour {

    private Transform schoolRH;
    private Transform schoolLH;

    [SerializeField] private float offsetXRH;
    [SerializeField] private float offsetYRH;
    [SerializeField] private float offsetZRH;

    [SerializeField] private float offsetXLH;
    [SerializeField] private float offsetYLH;
    [SerializeField] private float offsetZLH;

    public float fishSpeed;

    private Vector3 lastPos;
    private Vector3 dir;

    private bool switcher;

	// Use this for initialization
	void Start () {

        schoolRH = GameObject.Find("SchoolRH").transform;

        offsetXRH = transform.position.x - schoolRH.position.x;
        offsetYRH = transform.position.y - schoolRH.position.y;
        offsetZRH = transform.position.z - schoolRH.position.z;

        schoolLH = GameObject.Find("SchoolLH").transform;

        offsetXRH = transform.position.x - schoolLH.position.x;
        offsetYRH = transform.position.y - schoolLH.position.y;
        offsetZRH = transform.position.z - schoolLH.position.z;

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
        transform.position = Vector3.MoveTowards(transform.position, schoolRH.position + (schoolRH.right * offsetXRH) + (schoolRH.up * offsetYRH) + (schoolRH.forward * offsetZRH), fishSpeed * 60 * Time.deltaTime);

        if (switcher)
        {
            dir = Vector3.Normalize(transform.position - lastPos);
            if (dir != Vector3.zero)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir, Vector3.up), .09f);
            }
        }
    }
}
