﻿using System.Collections;
using UnityEngine;

namespace CVRLabSJSU
{
    public class ButtonPressed : MonoBehaviour
    {
        //public GameObject button;
        public AudioSource buttonSound;

        public ButtonAnimation pressButtonAnimation;

        //Molecule to spawmn
        public GameObject element;

        private bool elementSpawned = false;
        private float respawnTime = 1.5f;

        //Text Object to spawn
        //Molecule to spawmn
        public GameObject TextObj;

        public float textLeft = 4.0f;
        public float textBack = -6.0f;
        private bool textSpawned = false;

        // 1
        private SteamVR_TrackedObject trackedObj;

        // 2
        private SteamVR_Controller.Device Controller
        {
            get { return SteamVR_Controller.Input((int)trackedObj.index); }
        }

        private void Awake()
        {
            trackedObj = GetComponent<SteamVR_TrackedObject>();
        }

        // Use this for initialization
        private void Start()
        {
            buttonSound = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        private void Update()
        {
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "leftHand" || other.gameObject.tag == "rightHand")
            {
                Debug.Log("Button Pressed!");
                buttonSound.Play();
                buttonSound.Play(44100);
                pressButtonAnimation.pressButton();

                //Spawn Molecule
                if (!elementSpawned)
                {
                    if (!textSpawned)
                    {
                        Instantiate(TextObj, transform.position + new Vector3(textBack, 0, textLeft), Quaternion.Euler(150, -90, -180));
                        textSpawned = true;
                    }

                    Instantiate(element, transform.position + Vector3.up * 6.0f, transform.rotation);
                    elementSpawned = true;
                    StartCoroutine("Countdown", respawnTime);
                }
            }
        }

        //Allow Element to spawn after countdown
        private IEnumerator Countdown(int time)
        {
            while (time >= 0)
            {
                Debug.Log(time--);
                yield return new WaitForSeconds(1);
            }
            elementSpawned = false;
            Debug.Log("CountDown Complete: Can Spawn Element again");
        }
    }
}