using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZoombieGame
{
    public class Shoot : MonoBehaviour
    {
        GameController gameController;
        RectTransform rectTransform;

        GameObject audioSource;
        audio audio_player;
        // Start is called before the first frame update
        void Start()
        {
            rectTransform = GetComponent<RectTransform>();
            gameController = GameObject.Find("GameController").GetComponent<GameController>();

            audioSource = GameObject.Find("AudioSource");
            audio_player = audioSource.GetComponent<audio>();
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
            Debug.Log("zoombie : " + zoombie_x + "  shoot : " + worldPosition.x);

            if (Mathf.CeilToInt(zoombie_x) == Mathf.CeilToInt(worldPosition.x))
            {
                Debug.Log("Shoot");
                gameController.shoot();
                audio_player.play_shoot();
            }
            else if(Mathf.CeilToInt(zoombie_x) > Mathf.CeilToInt(worldPosition.x))
            {
                audio_player.play_cat_1();
            }
            else if (Mathf.CeilToInt(zoombie_x) < Mathf.CeilToInt(worldPosition.x))
            {
                audio_player.play_cat_2();
            }

        }
    }
}
