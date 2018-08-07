using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem
{

    public class MenuInteraction : MonoBehaviour
    {

        private Hand hand;
        public float swipeSum;
        public float touchLast;
        public float touchCurrent;
        public float distance;
        public bool hasSwipedLeft;
        public bool hasSwipedRight;
        public bool collidingKeyObject = false;
        public ObjectMenuManager objectMenuManager;
        // Use this for initialization
        void Start()
        {
            hand = GetComponent<Hand>();
        }

        // Update is called once per frame
        void Update()
        {

            if (hand.controller.GetTouchDown(SteamVR_Controller.ButtonMask.Touchpad))
            {

                touchLast = hand.controller.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad).x;
            }

            if (hand.controller.GetTouch(SteamVR_Controller.ButtonMask.Touchpad))
            {
                touchCurrent = hand.controller.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad).x;
                distance = touchCurrent - touchLast;
                touchLast = touchCurrent;
                swipeSum += distance;

                if (!hasSwipedRight)
                {
                    if (swipeSum > 0.5f)
                    {
                        swipeSum = 0;
                        SwipeRight();
                        hasSwipedRight = true;
                        hasSwipedLeft = false;
                    }
                }

                if (!hasSwipedLeft)
                {
                    if (swipeSum < -0.5f)
                    {
                        swipeSum = 0;
                        SwipeLeft();
                        hasSwipedLeft = true;
                        hasSwipedRight = false;
                    }
                }

            }
            if (hand.controller.GetTouchUp(SteamVR_Controller.ButtonMask.Touchpad))
            {
                swipeSum = 0;
                touchCurrent = 0;
                touchLast = 0;
                hasSwipedLeft = false;
                hasSwipedRight = false;
            }
            // HASTA AQUI TODO BIEN

            if (hand.controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
            {
                SpawnObject();
            }

        }

        void SpawnObject()
        {
            objectMenuManager.SpawnCurrentObject();
        }

        void SwipeLeft()
        {
            objectMenuManager.MenuLeft();
            Debug.Log("SwipeLeft");
        }
        void SwipeRight()
        {
            objectMenuManager.MenuRight();
            Debug.Log("SwipeRight");
        }
    }
}
