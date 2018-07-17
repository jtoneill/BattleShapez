using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject gameplayControllerUI;
    public EnemyWaves ew;

    public PlayerStats ps;

    


    void Start()
    {
        pauseMenuUI.SetActive(false);
        gameplayControllerUI.SetActive(true);
        Time.timeScale = 1f;

        ew = GameController.FindObjectOfType<EnemyWaves>();

        ps = GameController.FindObjectOfType<PlayerStats>();

        
    }

	void update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameplayControllerUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        ew.pauseFalse();
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameplayControllerUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        ew.pauseTrue();
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Main Menu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


   



  

}
