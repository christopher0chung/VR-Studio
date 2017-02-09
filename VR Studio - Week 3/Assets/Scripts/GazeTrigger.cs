using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GazeTrigger : MonoBehaviour {

    [SerializeField] float timer;
    [SerializeField] Image progressImage;

    public UnityEvent OnGazeComplete = new UnityEvent();

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
            timer += Time.deltaTime;
        }
        else
        {
            timer -= Time.deltaTime;
        }
        timer = Mathf.Clamp01(timer);


        progressImage.fillAmount = timer;

        if (timer >= 1)
        {
            timer = 0;
            OnGazeComplete.Invoke();
        }
   }
}
