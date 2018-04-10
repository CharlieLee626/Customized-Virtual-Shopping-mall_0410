using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SteamVR_TrackedObject))]  // require a component
public class PickupParent : Photon.MonoBehaviour {

	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
    bool isHolding = false;
    Collider c;


    //public Transform sphere;

	// Use this for initialization
	void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void FixedUpdate () {
		device = SteamVR_Controller.Input ((int)trackedObj.index); // get a reference to our device

        /*if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("You are holding 'Touch' the Trigger");
		}

		if (device.GetTouchDown (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("You activated TouchDown on the Trigger");
		}

		if (device.GetTouchUp (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("You activated TouchUp on the Trigger");
		}
		if (device.GetPress (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("You are holding 'Press' the Trigger");
		}

		if (device.GetPressDown (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("You activated PressDown on the Trigger");
		}

		if (device.GetPressUp (SteamVR_Controller.ButtonMask.Trigger)) {
			Debug.Log ("You activated PressUp on the Trigger");
		}
        
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("You activated PressUp on the Touchpad");
            sphere.transform.position = Vector3.zero;
            sphere.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            sphere.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        }
        */
        if (isHolding)
        {
            c.gameObject.transform.SetPositionAndRotation(this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
    }





    void OnTriggerStay(Collider col)
	{
        if(col.GetComponent<Item>() != null)
        {
            //col.gameObject.transform.FindChild(col.name + " Information")
            //col.gameObject.GetComponentInChildren<>
            
            //Debug.Log ("You have collided with" + col.name + "and activated OnTriggerStay");
            if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger) && isHolding == false)
            {
                Debug.Log("You have collided with" + col.name + "while holding down Touch");
                col.attachedRigidbody.isKinematic = true;

                col.gameObject.transform.SetPositionAndRotation(this.gameObject.transform.position, this.gameObject.transform.rotation);
                //col.gameObject.transform.SetParent(this.gameObject.transform);

                isHolding = true;
                c = col;

                col.gameObject.GetComponent<OnClickRequestOwnership>().OnClick();
                col.gameObject.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.player.ID);

            }
            if(isHolding)
            {
                col.gameObject.transform.SetPositionAndRotation(this.gameObject.transform.position, this.gameObject.transform.rotation);
            }

            if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                Debug.Log("You have released Touch while colliding with" + col.name);
                col.gameObject.transform.SetParent(null);
                col.attachedRigidbody.isKinematic = false;

                tossObject(col.attachedRigidbody);
                isHolding = false;
                //col.gameObject.GetComponent<PhotonView>().TransferOwnership(0);
            }

        }

    }

    void tossObject(Rigidbody rigidBody)
    {
        Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;
        if(origin != null)
        {
            rigidBody.velocity = origin.TransformVector(device.velocity);
            rigidBody.angularVelocity = origin.TransformVector(device.angularVelocity);
        }
        else
        {
            rigidBody.velocity = device.velocity;
            rigidBody.angularVelocity = device.angularVelocity;
        }
    }
}
