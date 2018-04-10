using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public static UI Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    // Lists that store 

    public UI()
    {
        // initialize an UI with full operation
    }

    // some function that is going to interact with the gameManger


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateTotalPrice()
    {

    }
}
