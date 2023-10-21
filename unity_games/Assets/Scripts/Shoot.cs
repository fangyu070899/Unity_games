using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZoombieGame
{
    public class Shoot : MonoBehaviour
    {
        GameController gameController;
        RectTransform rectTransform;

        // Start is called before the first frame update
        void Start()
        {
            rectTransform = GetComponent<RectTransform>();
            gameController = GameObject.Find("GameController").GetComponent<GameController>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnButtonClick()
        {
            Vector3 worldPosition = rectTransform.position;
            float zoombie_x = gameController.getZoombie();


            if (zoombie_x == -1.53f)
            {
                if(worldPosition.x < 82.62 && worldPosition.x > 10)
                {
                    Debug.Log("Left Shoot");
                    gameController.shoot();
                }
            }
            else if ( zoombie_x == 1.53f)
            {
                if (worldPosition.x < 238.14 && worldPosition.x > 160.38)
                {
                    Debug.Log("Right Shoot");
                    gameController.shoot();
                }
            }
            else if (zoombie_x == 0)
            {
                if (worldPosition.x > 82.62 && worldPosition.x < 160.38)
                {
                    Debug.Log("Middle Shoot");
                    gameController.shoot();
                }
            }

        }
    }
}
