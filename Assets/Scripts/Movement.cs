using UnityEngine;
using System.Collections;



public class Movement : MonoBehaviour
{
    //variables
    public float accel = 10.0f;
    public float decel = 0.5f;
    public float hspeed = 0.0f;
    public float vspeed = 0.0f;
    private const int MAX = 50;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        hspeed = Input.GetAxis("Horizontal") ;
        vspeed = Input.GetAxis("Vertical")   ;

        Vector3 move = new Vector3(hspeed, 0.0f, vspeed);

        rb.AddForce(move * accel,ForceMode.Acceleration);
    }


}
