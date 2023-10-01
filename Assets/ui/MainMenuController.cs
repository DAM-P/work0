using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1); // 加载游戏场景（场景名字根据实际设置）
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   
}
