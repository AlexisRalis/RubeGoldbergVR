using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser2 : MonoBehaviour
{

    public Respawn_Ball respawn;
    public AudioSource audioSource;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Laser2_Anim");
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            audioSource.Play();
            respawn.SpawnBall();

        }

    }
}
