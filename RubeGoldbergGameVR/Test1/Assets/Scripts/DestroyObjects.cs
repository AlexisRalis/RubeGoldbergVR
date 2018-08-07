using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem
{

    public class DestroyObjects : MonoBehaviour
    {

        private Hand hand;
        public bool keyObjectDetected;
        public bool destroyingObject;

        // Use this for initialization
        void Start()
        {
            hand = GetComponent<Hand>();
        }

        // Update is called once per frame

        public void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "KeyObject")
            {
                keyObjectDetected = true;
                Debug.Log("Key Object detected" + keyObjectDetected);
                if(hand.controller.GetPress(SteamVR_Controller.ButtonMask.Grip)){
                    Debug.Log("You are pressing the right GRIP");
                    destroyingObject = true;
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
