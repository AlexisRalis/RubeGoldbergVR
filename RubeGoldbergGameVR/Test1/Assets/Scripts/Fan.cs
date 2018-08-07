using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{

    private Rigidbody rb;
    public float force = 500f;

    public void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            rb = coll.GetComponent<Rigidbody>();
            Debug.Log("The ball entered the fan zone");
            rb.AddForce(transform.up * force);
            rb.useGravity = true;
        }
    }
}
