using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Menu
{
    public class audio : MonoBehaviour
    {
        public AudioClip cat_1;

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

        public void play_cat_1()
        {
            audiosource.PlayOneShot(cat_1);
        }


    }
}