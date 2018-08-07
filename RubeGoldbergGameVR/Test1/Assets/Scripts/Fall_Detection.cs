using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Detection : MonoBehaviour {

    public float lifeTime = 2f;
    private Transform origin;
    public GameObject ball;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
    public void OnCollisionEnter (Collision coll) {
        
        if (coll.gameObject.tag == "Ball"){
            Debug.Log("The ball is touching the ground, start again!");
            Destroy(coll.gameObject, lifeTime);
            Instantiate(ball, coll.gameObject.transform.position, coll.gameObject.transform.rotation);
        }
	}
}
