using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

//-----------------------
// Script is for the object to be interacted with
//-----------------------

public class HandToSphere : MonoBehaviour
{

    void Start()
    {
        //if (gameObject.name == "Hand1")
        //{
        //    GameObject.Find("LHSphere").GetComponent<HandRepresentation>().Init(transform, transform.parent.FindChild("VRCamera"));
        //}
        //else
        //{
        //    GameObject.Find("RHSphere").GetComponent<HandRepresentation>().Init(transform, transform.parent.FindChild("VRCamera"));
        //}
    }

    //// a hand is near
    //void HandHoverUpdate(Hand hand)
    //{
    //    if (hand.GetStandardInteractionButton()) //by default, it is trigger for controller, and left mouse button
    //    {
    //        hand.AttachObject(gameObject);
    //    }
    //}
    //// becomes attached
    //void OnAttachedToHand(Hand hand)
    //{
    //    GetComponent<Rigidbody>().isKinematic = true;
    //}
    //// runs while holding something
    //void HandAttachedUpdate(Hand hand)
    //{
    //    if (!hand.GetStandardInteractionButton())
    //    {
    //        hand.DetachObject(gameObject);
    //    }
    //}
    //// becomes detached
    //void OnDetachedFromHand(Hand hand)
    //{
    //    GetComponent<Rigidbody>().isKinematic = false;
    //    GetComponent<Rigidbody>().AddForce(hand.GetTrackedObjectVelocity() * 10f, ForceMode.Impulse);
    //    GetComponent<Rigidbody>().AddTorque(hand.GetTrackedObjectAngularVelocity() * 10f, ForceMode.Impulse);
    //}
}