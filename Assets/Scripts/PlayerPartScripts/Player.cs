using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    // variables
    public string ShipName;
    public int TotalHullpoints;

    public int size;
    public int WeaponCount;

    public int ShipSize;

    public int TotalThrust;

    public Transform shipParts;

	// Use this for initialization
	void Start ()
    {
	    foreach (GameObject child in shipParts)
        {
            if (child.GetComponent<Parts>().Part == 0) break;
            TotalHullpoints += child.GetComponent<Parts>().HullValue;
            ShipSize += child.GetComponent<Parts>().SizeValue; 
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}



}
