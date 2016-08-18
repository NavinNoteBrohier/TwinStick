using UnityEngine;
using System.Collections;

public enum WeaponType
{
    Empty, Bullet, Lazer, Rocket
}
public enum PartType
{
    Empty, Cockpit, WingLeft, WingRight, Weapon, Chassis, Thruster, Armour
}

public class Parts : MonoBehaviour {

    //Part Variables
    public int Part;
    public int Weapon;
    public int DamageValue;

    public int ThrustValue;
    public int SizeValue;
    public int WeaponValue;
    public int HullValue;

	// Use this for initialization
	void Start ()
    {
	    switch(Part)
        {
            case 0: // Empty
                break;
            case 1: // Cockpit
                SizeValue    = 1;
                HullValue    = 10;
                break;
            case 2: // Wingleft
                SizeValue    = 1;
                HullValue    = 10;
                break;
            case 3: // WingRight
                SizeValue   = 1;
                HullValue   = 10; 
                break;
            case 4: // Weapon
                SizeValue   = 1;
                HullValue   = 10;
                WeaponValue = 5;
                DamageValue = 5;
                break;
            case 5: // Chassis
                SizeValue   = 1;
                HullValue   = 10;
                break;
            case 6: // Thruster
                SizeValue   = 1;
                HullValue   = 10;
                break;
            case 7: // Armour
                SizeValue   = 1;
                HullValue   = 10;
                break;
            default:
                break;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
