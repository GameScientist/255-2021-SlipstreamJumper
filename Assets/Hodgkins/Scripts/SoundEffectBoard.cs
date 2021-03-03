using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hodgkins
{       
    public class SoundEffectBoard : MonoBehaviour
    {
        public static SoundEffectBoard main;
        
        public AudioClip soundJump;
        public AudioClip soundSpring;
        public AudioClip soundHit;
        public AudioClip soundDie;

        private AudioSource player;

        void Start()
        {
            if(main == null)
            {
                main = this;
                player = GetComponent<AudioSource>();
            } else {
                Destroy(this.gameObject);
            }
        }

        public static void PlayJump()
        {
            main.player.PlayOneShot(main.soundJump);
        }

        public static void PlaySpring()
        {
            main.player.PlayOneShot(main.soundSpring);
        }

        public static void PlayHit()
        {
            main.player.PlayOneShot(main.soundHit);
        }
    }
}