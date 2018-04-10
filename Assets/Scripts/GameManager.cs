using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Use this for initialization

    // class :
    // public enum GameState{ setting, shopping, checking, closing }

    
    // objects :
    /* GameState gameState
     * User user(...), partner(...);
     * UI ui(...);
    */
    // functions :
    /* Init()
     * produce_customized_item()
     * check()結帳
     * 
     * close()
    */

    public void Init()
    {
        // initialize the VR shopping mall, do UI showing and ask the user to choose character
        // ui.show(...)
    }

    public void getUserSettings() // since a return below the void must be changed
    {
        // get the user's setting(sellection) from the ui (?)  user chooses character and partner on the UI 

        // return required
    }

    public void setUserAndPartner()
    {
        // set the objects user and partner
    }

    public void lookUpTable()
    {
        // determine the type of the user partner pair
    }

    public void produceCustomizedItem()
    {
        // based on the user's sellection, exploit the look-up table to know which set of items are going to appear in the scene
        // call functions in the scripts that init the scene
    }

    public void strartScene()
    {
        // start the scene "main"
    }

    public void showUI()
    {
        // showing details of the shopping process (game state must be shopping) 
    }

    public void check()
    {

    }
    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
