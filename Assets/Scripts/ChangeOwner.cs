using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOwner : Photon.MonoBehaviour
{

    public VRTK.VRTK_InteractableObject toss;

    // Use this for initialization
    void Start()
    {
        toss.InteractableObjectGrabbed += Toss_InteractableObjectGrabbed;
        StartCoroutine(Pop());
    }

    private void Toss_InteractableObjectGrabbed(object sender, VRTK.InteractableObjectEventArgs e)
    {
        toss.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.player.ID);
    }

    IEnumerator Pop()
    {
        yield return new WaitForSeconds(10f);
    }
}
