using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZoombieGame
{
    public class Zoombie : MonoBehaviour
    {
        private Transform transform;

        // Start is called before the first frame update
        void Start()
        {
            this.transform = gameObject.GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            checkPosition();
        }

        public void checkPosition()
        {
            Vector3 currentPosition = transform.position;
            if (currentPosition.y < -2.0f)
            {
                Destroy(gameObject);
                Debug.Log("destroy zoombie out of range");
            }
        }

    }
}