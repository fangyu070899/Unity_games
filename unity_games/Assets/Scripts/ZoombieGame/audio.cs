using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ZoombieGame
{
    public class audio : MonoBehaviour
    {
        public AudioClip button_1;
        public AudioClip score;
        public AudioClip cat_1;
        public AudioClip cat_2;
        public AudioClip shoot;

        AudioSource audiosource;

        // Start is called before the first frame update
        void Start()
        {

            audiosource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void play_shoot()
        {
            audiosource.PlayOneShot(shoot);
        }

        public void play_cat_1()
        {
            audiosource.PlayOneShot(cat_1);
        }

        public void play_cat_2()
        {
            audiosource.PlayOneShot(cat_2);
        }

        public void play_button_1()
        {
            audiosource.PlayOneShot(button_1);
        }

        public void play_score()
        {
            audiosource.PlayOneShot(score);
        }

    }
}