using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused = false;
    private void Start()
    {
        pauseMenu.SetActive(isPaused);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TogglePauseMenu();
            //Debug.Log("ttyt");
        }
    }

    public void TogglePauseMenu()

    {
        //Debug.Log("ttt");
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);

        Time.timeScale = isPaused ? 0f : 1f;
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
