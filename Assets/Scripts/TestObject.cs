using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody>().AddTorque(Vector3.one * 10f, ForceMode.Acceleration);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            gameObject.transform.position += Vector3.up * 1f;
        }
    }
}
