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
            List<float> index = gameController.getButtonIndex();
            Debug.Log("zoombie : " + zoombie_x + "shoot : " + worldPosition.x);

            if (zoombie_x == worldPosition.x)
            {
                Debug.Log("Left Shoot");
                gameController.shoot();
            }

        }
    }
}
