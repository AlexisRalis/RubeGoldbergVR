using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

    public Respawn_Ball respawn;
    public AudioSource audioSource;

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
