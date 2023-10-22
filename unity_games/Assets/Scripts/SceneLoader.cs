using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public string targetSceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 当按钮被点击时调用的方法
    public void LoadTargetScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }

}
