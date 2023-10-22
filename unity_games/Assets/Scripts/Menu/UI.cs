using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace Menu
{
    public class UI : MonoBehaviour
    {
        private Button btn_zoombie;

        // Start is called before the first frame update
        void Start()
        {
            btn_zoombie = GameObject.Find("btn_zoombie").GetComponent<Button>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void setBtnInteractable(Button btn, bool boolean)
        {
            btn.interactable = boolean;
        }

    }
}

