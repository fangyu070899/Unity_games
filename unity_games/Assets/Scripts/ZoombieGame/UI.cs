using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace ZoombieGame
{
    public class UI : MonoBehaviour
    {
        public Sprite startImage_0;
        public Sprite startImage_1;
        public Sprite startImage_2;

        private Button button_0;
        private Button button_1;
        private Button button_2;

        private GameObject time;
        private TextMeshProUGUI countdownText;

        private GameObject score;
        private TextMeshProUGUI totalScore;

        private GameObject startImage;
        private Image countdownImage;

        private GameObject endImage;

        private GameObject menuImage;

        // Start is called before the first frame update
        void Start()
        {
            time = GameObject.Find("time");
            countdownText = time.GetComponent<TextMeshProUGUI>();
            score = GameObject.Find("score");
            totalScore = score.GetComponent<TextMeshProUGUI>();

            startImage = GameObject.Find("startImage");
            countdownImage = startImage.GetComponent<Image>();
            endImage = GameObject.Find("endImage");
            endImage.SetActive(false);
            menuImage = GameObject.Find("menuImage");
            menuImage.SetActive(false);

            button_0 = GameObject.Find("button_0").GetComponent<Button>(); 
            button_1 = GameObject.Find("button_1").GetComponent<Button>(); 
            button_2 = GameObject.Find("button_2").GetComponent<Button>();
            setBtnInteractable(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void updateTime(int time)
        {
            countdownText.text = time.ToString();
        }

        public void changeStartImage(int time)
        {
            Debug.Log(time);
            switch (time)
            {
                case 1:
                    countdownImage.sprite = startImage_0;
                    break;
                case 2:
                    countdownImage.sprite = startImage_1;
                    break;
                case 3:
                    countdownImage.sprite = startImage_2;
                    break;
                default:
                    Destroy(countdownImage);
                    break;
            }
        }

        public void menu(bool boolean)
        {
            menuImage.SetActive(boolean);
        }

        public void gameOver(int score)
        {
            totalScore.text = score.ToString();
            totalScore.enabled = true;
            endImage.SetActive(true);
        }

        public void setBtnInteractable(bool boolean)
        {
            button_0.interactable = boolean;
            button_1.interactable = boolean;
            button_2.interactable = boolean;
        }

        public List<float> countButtonIndex()
        {
            List<float> index = new List<float>();

            RectTransform button0RectTransform = GameObject.Find("button_0").GetComponent<RectTransform>();
            RectTransform button1RectTransform = GameObject.Find("button_1").GetComponent<RectTransform>();
            RectTransform button2RectTransform = GameObject.Find("button_2").GetComponent<RectTransform>();

            Vector3 button0Position = button0RectTransform.position;
            Vector3 button1Position = button1RectTransform.position;
            Vector3 button2Position = button2RectTransform.position;

            float delta = (button1Position.x - button0Position.x) / 2;


            // 三個按鈕的中心點 012
            index.Add(button0Position.x);
            index.Add(button1Position.x);
            index.Add(button2Position.x);

            // 按鈕最高點 3
            index.Add(button0Position.y + delta);

            Debug.Log(index[0]);
            Debug.Log(index[1]);
            Debug.Log(index[2]);
            Debug.Log(index[3]);

            return index;
        }

    }
}

