using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZoombieGame
{
    public class GameController : MonoBehaviour
    {
        public GameObject zoombie0;
        public GameObject zoombie1;
        public GameObject zoombie2;
        public GameObject zoombie3;
        private List<GameObject> zoombies = new List<GameObject>();

        float highest = 7.22f;
        float lowest = -1.78f;

        public int killed = 0;

        // Start is called before the first frame update
        void Start()
        {
            float tmp_y = lowest;
            float tmp_z = 10f;
            for (int i = 0; i < 10; i++)
            {
                GameObject obj = Instantiate(zoombie0, new Vector3(random_x(), tmp_y, tmp_z), Quaternion.identity);
                zoombies.Add(obj);
                tmp_y = tmp_y + 1f;
                tmp_z = tmp_z - 1f;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void shoot()
        {
            killed += 1;
            deleteZoombie();
            moveZoombie();
            addZoombie();
        }

        public float getZoombie()
        {
            Transform transform = zoombies[0].GetComponent<Transform>();
            Vector3 currentPosition = transform.position;
            Debug.Log(currentPosition.x);
            return currentPosition.x;
        }

        public void addZoombie()
        {
            GameObject obj;
            if (killed <= 20)
            {
                obj = Instantiate(zoombie0, new Vector3(random_x(), highest, 10), Quaternion.identity);
            }
            else if (killed <= 50)
            {
                obj = Instantiate(zoombie1, new Vector3(random_x(), highest, 10), Quaternion.identity);
            }
            else if (killed <= 100)
            {
                obj = Instantiate(zoombie2, new Vector3(random_x(), highest, 10), Quaternion.identity);
            }
            else
            {
                obj = Instantiate(zoombie3, new Vector3(random_x(), highest, 10), Quaternion.identity);
            }
            zoombies.Add(obj);
        }

        public void deleteZoombie()
        {
            GameObject obj = zoombies[0];
            zoombies.RemoveAt(0);
            if(obj!=null)Destroy(obj);
        }

        public void moveZoombie()
        {

            for (int i = 0; i < zoombies.Count; i++)
            {
                Transform transform = zoombies[i].GetComponent<Transform>();
                Vector3 currentPosition = transform.position;
                currentPosition.y -= 1.0f;
                currentPosition.z -= 1.0f;
                transform.position = currentPosition;
            }
        }

        public float random_x()
        {
            int randomInt = Random.Range(0, 3);
            switch (randomInt)
            {
                case 0:
                    return -1.53f;
                case 1:
                    return 0f;
                case 2:
                    return 1.53f;
                default:
                    return 0f;
            }
        }
    }
}

