using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public Material[] material;
    private Renderer rend;
    public AudioSource audioSource;

    void Start()
    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnTriggerEnter (Collider col) {

        if(col.gameObject.tag == "Win_Ball"){
            rend.sharedMaterial = material[1];
        }
        else if(col.gameObject.tag == "Ball"){
            audioSource.Play();
            rend.sharedMaterial = material[2];
        }
        else{
            rend.sharedMaterial = material[0];
        }

	}

}
