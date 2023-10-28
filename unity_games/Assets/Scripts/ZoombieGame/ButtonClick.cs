using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZoombieGame
{
    public class ButtonClick : MonoBehaviour
    {
        GameController gameController;
        private GameObject canvas;
        private UI canvasUI;

        // Start is called before the first frame update
        void Start()
        {
            gameController = GameObject.Find("GameController").GetComponent<GameController>();
            canvas = GameObject.Find("Canvas");
            canvasUI = canvas.GetComponent<UI>();

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void pause()
        {
            gameController.Pause(true);
            canvasUI.setBtnInteractable(false);
            canvasUI.menu(true);
        }

        public void continue_click()
        {
            gameController.Pause(false);
            canvasUI.menu(false);
        }


    }
}
