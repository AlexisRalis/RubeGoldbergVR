using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Ball : MonoBehaviour {

    public GameObject ball;
    private Vector3 origin;
    public float lifeTime = 2f;
    private GameObject ballCopy;
    public bool fail;
    public Collectable collectable;
    public Collectable collectable2;
    public Collectable collectable3;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        origin = ball.transform.position;
        ball.tag = "Ball";
	}

    public void SpawnBall()
    {
        ballCopy = Instantiate(ball, origin, Quaternion.identity);
        ballCopy.tag = "Ball";

    }

    private void Update()
    {
        if(!collectable.isActiveAndEnabled && !collectable2.isActiveAndEnabled && !collectable3.isActiveAndEnabled){
            ball.tag = "Win_Ball";
        }
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "Floor")
        {
            ball.tag = "Ball";
            audioSource.Play();
            fail = true;
            SpawnBall();
            collectable.restartCollectable();
            collectable2.restartCollectable();
            collectable3.restartCollectable();
            Debug.Log("Fail = "+ fail +" The ball is touching the ground, start again!");
            Destroy(gameObject, lifeTime);

        }
    }

}
