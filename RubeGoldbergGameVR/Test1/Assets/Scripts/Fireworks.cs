using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireworks : MonoBehaviour {

    public ParticleSystem fireworks;
    public GameObject[] ballons;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        fireworks.Play();
        ballons[0].SetActive(true);
        ballons[1].SetActive(true);
        ballons[2].SetActive(true);
        ballons[3].SetActive(true);
        audioSource.Play();
	}
}
