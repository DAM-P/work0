using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1); // ������Ϸ�������������ָ���ʵ�����ã�
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   
}
