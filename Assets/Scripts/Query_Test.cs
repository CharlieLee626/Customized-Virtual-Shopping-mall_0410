using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.Data.SqlClient;
using System;
using MySql.Data;
using MySql.Data.MySqlClient;



public class Query_Test : MonoBehaviour {

    public string queryString = "SELECT First_Preference, Second_Preference, Third_Preference, Fourth_Preference  FROM  preference";
    public string connectionString = "Server=54.65.227.211;Database=VR_User_Preference;User Id=ed716;Password=nctu716;";

    public string FP, SP, TP;

    public static Query_Test Instance;
    public int P1_ith_store;
    public int P2_ith_store;




    public void Notshow(string first, string second, string third)
    {
        for(int i = 1; i<=8; i++)
        {
            if (i.ToString() != first && i.ToString() != second && i.ToString() != third)
            {
                GameObject.Find("Lights (" + i.ToString() + ")").SetActive(false);
                GameObject.Find("shopcart (" + i.ToString() + ")").SetActive(false);
                GameObject.Find("Interior (" + i.ToString() + ")").SetActive(false);
                GameObject.Find("Items (" + i.ToString() + ")").SetActive(false);
                GameObject.Find("Canvas (" + i.ToString() + ")").SetActive(false);
            }
        }
    }
    

    // Use this for initialization
    void Start () {
        Debug.Log("RUN Q_TEST");


        /*
        SqlConnection sqlConnection1 = new SqlConnection("Server=54.65.227.211;Database=VR_User_Preference;User Id=ed716;Password=nctu716;Trusted_Connection=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = "SELECT First_Preference, Second_Preference, Third_Preference, Fourth_Preference  FROM  preference";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = sqlConnection1;

        sqlConnection1.Open();

        reader = cmd.ExecuteReader();
        // Data is accessible through the DataReader object here.
        try
        {
            while (reader.Read())
            {
                Debug.Log(String.Format("{0}, {1}, {2}, {3}",
                reader["First_Preference"], reader["Second_Preference"], reader["Third_Preference"], reader["Fourth_Preference"] ));// etc
            }
        }
        finally
        {
            // Always call Close when done reading.
            Debug.Log("Query Failed");
            reader.Close();
        }

        sqlConnection1.Close();
        */


        string connectionString =
          "Server=54.65.227.211;" +
          "Database=VR_User_Preference;" +
          "User ID=ed716;" +
          "Password=nctu716;" +
          "Pooling=false";
        IDbConnection dbcon;
        dbcon = new MySqlConnection(connectionString);
        dbcon.Open();
        IDbCommand dbcmd = dbcon.CreateCommand();
        // requires a table to be created named employee
        // with columns firstname and lastname
        // such as,
        //        CREATE TABLE employee (
        //           firstname varchar(32),
        //           lastname varchar(32));
        string sql = "SELECT First, Second, Third  FROM  Group_preference";
        dbcmd.CommandText = sql;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            FP = (string)reader["First"];
            SP = (string)reader["Second"];
            TP = (string)reader["Third"];
            //string FourthP = (string)reader["Fourth_Preference"];
            Debug.Log("Name: " +
                  FP + " " + SP + " " + TP);
            //Notshow(FP, SP, TP);
        }

        P1_ith_store = 0;
        P2_ith_store = 0;
        Notshow(FP, SP, TP);



        // clean up
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbcon.Close();
        dbcon = null;
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
