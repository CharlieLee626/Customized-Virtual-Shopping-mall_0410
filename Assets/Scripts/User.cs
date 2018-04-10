using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour {

    // class : 
    /*
    */

    // object :
    /*
     * String name
     * int userID   //based on name, 0-4 for look-up table
    */

    //function :
    /*
    */

    //string name; // name might be default object ?
    int userID;    //based on name, 0-4 for look-up table


    public User()
    {
        this.name = null;
        this.userID = -1;
    }
    public User(string name)
    {
        this.name = name;
        if (name == "Adam") { userID = 0; }
        if (name == "Bob") { userID = 1; }
        if (name == "Cindy") { userID = 2; }
        if (name == "David") { userID = 3; }
        if (name == "Eric") { userID = 4; }
    }

    public string getName()
    {
        return this.name;
    }

    public int getUserID()
    {
        return this.userID;
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
