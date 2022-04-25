using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 RS


 main
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //public GameObject GameUI;
    public GameObject PauseUI;
    public bool IsPaused;
    //public int coins = 0;
    public int Health = 100;
    // Start is called before the first frame update
 RS
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int Health;


    // Start is called before the first frame update
    void Start()
    {

 main
        if (instance is null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
 RS


            DestroyImmediate(gameObject); 
        }
    }
 main

            DestroyImmediate(gameObject);
        }
    }
 RS
}


    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.Health <= 0)
        {
            SceneManager.LoadScene("GameOver");
            GameManager.instance.Health = 100;
            
        }

    }
}
 main
