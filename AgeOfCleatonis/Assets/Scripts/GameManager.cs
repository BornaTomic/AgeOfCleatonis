using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //public GameObject GameUI;
    public GameObject PauseUI;
    public bool IsPaused;
    //public int coins = 0;
 LM
    public int health = 0;

    public int Health = 100;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 RS


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int Health;


 main
    // Start is called before the first frame update
    void Start()
    {

 main
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
}

 RS


            DestroyImmediate(gameObject); 
        }
    }
 LM

 main

            DestroyImmediate(gameObject);
        }
    }
 RS
}

 main
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
 main
