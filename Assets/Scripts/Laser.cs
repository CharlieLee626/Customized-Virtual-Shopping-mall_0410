using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour {


    public GameObject laser;
    public GameObject Probe;

    public Transform cameraRigTransform;
    public Transform headTransform;

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    bool isHolding = false;

    /*
    public GameObject teleportReticlePrefab;
    private GameObject reticle;
    private Transform teleportReticleTransform;
    public Vector3 teleportReticleOffset;
    public LayerMask teleportMask;
    private bool shouldTeleport;
    */

    private SteamVR_TrackedObject rightController;
    // Use this for initialization

    private void Awake()
    {
        rightController = GetComponent<SteamVR_TrackedObject>();
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        laser.transform.rotation = this.transform.rotation;
        CheckIfHit();
	}

    void FixedUpdate()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index); // get a reference to our device
    }

    void CheckIfHit()
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(this.transform.position, this.transform.rotation * Vector3.forward,out hitInfo);
        if (hit)
        { 
            print(hitInfo.collider.name);
            Probe.transform.position = hitInfo.point;
            laser.transform.position = (Probe.transform.position + this.transform.position)/2;
            laser.transform.localScale = new Vector3((float)0.01 , (float)0.01 , Vector3.Distance(Probe.transform.position, this.transform.position) );

            if (SteamVR_Controller.Input((int)rightController.index).GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                print("InTrigger");
                if(hitInfo.collider.GetComponent<Button>() != null)
                {
                    hitInfo.collider.GetComponent<Button>().onClick.Invoke();

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton")
                    {
                        if (PhotonNetwork.isMasterClient)
                        {
                            if (Query_Test.Instance.P1_ith_store == 3)
                                this.transform.root.transform.position = new Vector3(0, 0, 0);

                            else if (Query_Test.Instance.P1_ith_store == 2)
                            {
                                if (Query_Test.Instance.TP == "1")
                                    this.transform.root.transform.position = new Vector3(0, 0, -27);
                                if (Query_Test.Instance.TP == "2")
                                    this.transform.root.transform.position = new Vector3(0, 0, -55);
                                if (Query_Test.Instance.TP == "3")
                                    this.transform.root.transform.position = new Vector3(0, 0, -86);
                                if (Query_Test.Instance.TP == "4")
                                    this.transform.root.transform.position = new Vector3(0, 0, -116);
                                if (Query_Test.Instance.TP == "5")
                                    this.transform.root.transform.position = new Vector3(0, 0, -145);
                                if (Query_Test.Instance.TP == "6")
                                    this.transform.root.transform.position = new Vector3(0, 0, -178);
                                if (Query_Test.Instance.TP == "7")
                                    this.transform.root.transform.position = new Vector3(0, 0, -206);
                                if (Query_Test.Instance.TP == "8")
                                    this.transform.root.transform.position = new Vector3(0, 0, -238);

                                Query_Test.Instance.P1_ith_store += 1;
                            }

                            else if (Query_Test.Instance.P1_ith_store == 1)
                            {
                                if (Query_Test.Instance.SP == "1")
                                    this.transform.root.transform.position = new Vector3(0, 0, -27);
                                if (Query_Test.Instance.SP == "2")
                                    this.transform.root.transform.position = new Vector3(0, 0, -55);
                                if (Query_Test.Instance.SP == "3")
                                    this.transform.root.transform.position = new Vector3(0, 0, -86);
                                if (Query_Test.Instance.SP == "4")
                                    this.transform.root.transform.position = new Vector3(0, 0, -116);
                                if (Query_Test.Instance.SP == "5")
                                    this.transform.root.transform.position = new Vector3(0, 0, -145);
                                if (Query_Test.Instance.SP == "6")
                                    this.transform.root.transform.position = new Vector3(0, 0, -178);
                                if (Query_Test.Instance.SP == "7")
                                    this.transform.root.transform.position = new Vector3(0, 0, -206);
                                if (Query_Test.Instance.SP == "8")
                                    this.transform.root.transform.position = new Vector3(0, 0, -238);

                                Query_Test.Instance.P1_ith_store += 1;
                            }

                            else if (Query_Test.Instance.P1_ith_store == 0)
                            {
                                if (Query_Test.Instance.FP == "1")
                                    this.transform.root.transform.position = new Vector3(0, 0, -27);
                                if (Query_Test.Instance.FP == "2")
                                    this.transform.root.transform.position = new Vector3(0, 0, -55);
                                if (Query_Test.Instance.FP == "3")
                                    this.transform.root.transform.position = new Vector3(0, 0, -86);
                                if (Query_Test.Instance.FP == "4")
                                    this.transform.root.transform.position = new Vector3(0, 0, -116);
                                if (Query_Test.Instance.FP == "5")
                                    this.transform.root.transform.position = new Vector3(0, 0, -145);
                                if (Query_Test.Instance.FP == "6")
                                    this.transform.root.transform.position = new Vector3(0, 0, -178);
                                if (Query_Test.Instance.FP == "7")
                                    this.transform.root.transform.position = new Vector3(0, 0, -206);
                                if (Query_Test.Instance.FP == "8")
                                    this.transform.root.transform.position = new Vector3(0, 0, -238);

                                Query_Test.Instance.P1_ith_store += 1;
                            }
                        }
                        else
                        {
                            if (Query_Test.Instance.P2_ith_store == 3)
                                this.transform.root.transform.position = new Vector3(0, 0, 0);

                            else if (Query_Test.Instance.P2_ith_store == 2)
                            {
                                if (Query_Test.Instance.TP == "1")
                                    this.transform.root.transform.position = new Vector3(0, 0, -27);
                                if (Query_Test.Instance.TP == "2")
                                    this.transform.root.transform.position = new Vector3(0, 0, -55);
                                if (Query_Test.Instance.TP == "3")
                                    this.transform.root.transform.position = new Vector3(0, 0, -86);
                                if (Query_Test.Instance.TP == "4")
                                    this.transform.root.transform.position = new Vector3(0, 0, -116);
                                if (Query_Test.Instance.TP == "5")
                                    this.transform.root.transform.position = new Vector3(0, 0, -145);
                                if (Query_Test.Instance.TP == "6")
                                    this.transform.root.transform.position = new Vector3(0, 0, -178);
                                if (Query_Test.Instance.TP == "7")
                                    this.transform.root.transform.position = new Vector3(0, 0, -206);
                                if (Query_Test.Instance.TP == "8")
                                    this.transform.root.transform.position = new Vector3(0, 0, -238);

                                Query_Test.Instance.P2_ith_store += 1;
                            }

                            else if (Query_Test.Instance.P2_ith_store == 1)
                            {
                                if (Query_Test.Instance.SP == "1")
                                    this.transform.root.transform.position = new Vector3(0, 0, -27);
                                if (Query_Test.Instance.SP == "2")
                                    this.transform.root.transform.position = new Vector3(0, 0, -55);
                                if (Query_Test.Instance.SP == "3")
                                    this.transform.root.transform.position = new Vector3(0, 0, -86);
                                if (Query_Test.Instance.SP == "4")
                                    this.transform.root.transform.position = new Vector3(0, 0, -116);
                                if (Query_Test.Instance.SP == "5")
                                    this.transform.root.transform.position = new Vector3(0, 0, -145);
                                if (Query_Test.Instance.SP == "6")
                                    this.transform.root.transform.position = new Vector3(0, 0, -178);
                                if (Query_Test.Instance.SP == "7")
                                    this.transform.root.transform.position = new Vector3(0, 0, -206);
                                if (Query_Test.Instance.SP == "8")
                                    this.transform.root.transform.position = new Vector3(0, 0, -238);

                                Query_Test.Instance.P2_ith_store += 1;
                            }

                            else if (Query_Test.Instance.P2_ith_store == 0)
                            {
                                if (Query_Test.Instance.FP == "1")
                                    this.transform.root.transform.position = new Vector3(0, 0, -27);
                                if (Query_Test.Instance.FP == "2")
                                    this.transform.root.transform.position = new Vector3(0, 0, -55);
                                if (Query_Test.Instance.FP == "3")
                                    this.transform.root.transform.position = new Vector3(0, 0, -86);
                                if (Query_Test.Instance.FP == "4")
                                    this.transform.root.transform.position = new Vector3(0, 0, -116);
                                if (Query_Test.Instance.FP == "5")
                                    this.transform.root.transform.position = new Vector3(0, 0, -145);
                                if (Query_Test.Instance.FP == "6")
                                    this.transform.root.transform.position = new Vector3(0, 0, -178);
                                if (Query_Test.Instance.FP == "7")
                                    this.transform.root.transform.position = new Vector3(0, 0, -206);
                                if (Query_Test.Instance.FP == "8")
                                    this.transform.root.transform.position = new Vector3(0, 0, -238);

                                Query_Test.Instance.P2_ith_store += 1;
                            }

                        }
                    }
                    /*
                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton0")
                        this.transform.root.transform.position = new Vector3(0, 0, -27);

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton1")
                        this.transform.root.transform.position = new Vector3(0, 0, -55);

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton2")
                        this.transform.root.transform.position = new Vector3(0, 0, -86);

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton3")
                        this.transform.root.transform.position = new Vector3(0, 0, -116);

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton4")
                        this.transform.root.transform.position = new Vector3(0, 0, -145);

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton5")
                        this.transform.root.transform.position = new Vector3(0, 0, -178);

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton6")
                        this.transform.root.transform.position = new Vector3(0, 0, -206);

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton7")
                        this.transform.root.transform.position = new Vector3(0, 0, -238);

                    if (hitInfo.collider.GetComponent<Button>().name == "ChangeSceneButton8")
                        this.transform.root.transform.position = new Vector3(0, 0, 0);
                    */
                }

//////Special Function For demo vedio
                //hitInfo.collider.attachedRigidbody.isKinematic = true;
                //hitInfo.collider.gameObject.transform.SetParent(this.gameObject.transform);
            }
            
            //if (SteamVR_Controller.Input((int)rightController.index).GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
            //{
                //hitInfo.collider.gameObject.transform.SetParent(null);
                //hitInfo.collider.attachedRigidbody.isKinematic = false;
                //tossObject(hitInfo.collider.attachedRigidbody);
            //}
//////Special Function For demo vedio

            if (SteamVR_Controller.Input((int)rightController.index).GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
            {
                Vector3 hitpoint = new Vector3(hitInfo.point.x, 0 , hitInfo.point.z);
                Vector3 difference = cameraRigTransform.position - headTransform.position;
                // Vector3 difference = this.transform.root.transform.position - this.transform.root.FindChild("Camrea (head)").transform.position;
                difference.y = 0;
                this.transform.root.transform.position = hitpoint + difference;
            }
            
        }
    }
/*
//////Special Function For demo vedio
    void tossObject(Rigidbody rigidBody)
    {
        Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;
        if (origin != null)
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
//////Special Function For demo vedio
*/
}
