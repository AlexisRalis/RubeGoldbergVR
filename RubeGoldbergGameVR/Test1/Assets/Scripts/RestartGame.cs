using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    public float timer = 2f;
    public SceneManager scene;
    public AudioSource audioSource;
    public Respawn_Ball respawn_Ball;
    public string level;
    private float lifeTime = 2f;

    void GoToScene()
    {
        SceneManager.LoadScene(level);
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Win_Ball")
        {

            audioSource.Play();
            Invoke("GoToScene", timer);
        }
        if (other.gameObject.tag == "Ball")
        {
            respawn_Ball.SpawnBall();
            Destroy(other.gameObject);
        }
    }
}
