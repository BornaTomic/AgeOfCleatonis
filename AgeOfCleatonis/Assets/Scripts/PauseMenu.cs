using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    // Start is called before the first frame update
    //public GameObject PauseUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                PauseOn();
            }
        }
    }
    public void Resume()
    {
        GameManager.instance.PauseUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    void PauseOn()
    {
        GameManager.instance.PauseUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
