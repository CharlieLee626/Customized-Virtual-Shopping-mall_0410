using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{

    public GameObject Info;
    public GameObject LeftController;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (this.GetComponent<Collider>().attachedRigidbody.isKinematic)
        {
            Info.transform.position = new Vector3(LeftController.transform.position.x + (float)0.1, LeftController.transform.position.y + (float)0.3, LeftController.transform.position.z + (float)0.2);
            Info.transform.rotation = LeftController.transform.rotation;
            
            Info.SetActive(true);
        }
        else
        {
            Info.SetActive(false);
        } 
    }
}