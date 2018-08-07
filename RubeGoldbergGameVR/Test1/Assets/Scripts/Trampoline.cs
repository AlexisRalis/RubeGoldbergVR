using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    private Rigidbody rb;
    public float force = 250f;
    public AudioSource audioSource;

    public void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            audioSource.Play();
            rb = coll.GetComponent<Rigidbody>();
            Debug.Log("The ball entered the trampoline zone");
            rb.AddForce(transform.up * force);
            rb.useGravity = true;
        }
    }
}
