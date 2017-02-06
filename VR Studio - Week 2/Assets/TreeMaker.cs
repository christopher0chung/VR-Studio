using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMaker : MonoBehaviour {

    public GameObject treePrefab;

    public float number;
    public float range;

    private float ang;
    private float scale;

	void Start () {		
        for (int i = 0; i < number; i++)
        {
            GameObject thisTree = (GameObject) Instantiate(treePrefab, new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range)), Quaternion.Euler(0, Random.Range(-180, 180), 0), transform);
            scale = Random.Range(25f, 100f);
            thisTree.transform.localScale = Vector3.one * scale;
        }
	}
}
