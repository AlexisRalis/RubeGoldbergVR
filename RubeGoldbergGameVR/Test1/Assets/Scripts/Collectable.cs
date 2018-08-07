using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    // Use this for initialization
    public GameObject ball;
    public Respawn_Ball respawn_Ball;
    public GameObject collectable;
    public AudioSource audioSource;
    public Animator anim;
  

    void Start()
    {
        collectable.gameObject.SetActive(true);
        anim = GetComponent<Animator>();
        anim.Play("Collectable_Anim");
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Ball")
        {
            
            Debug.Log("The ball touched the collectable object");
            collectable.gameObject.SetActive(false);
            audioSource.Play();
        }
    }

    public void restartCollectable(){
        collectable.SetActive(true);
    }
}

