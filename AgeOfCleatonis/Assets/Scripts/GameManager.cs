using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 RS

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //public GameObject GameUI;
    public GameObject PauseUI;
    public bool IsPaused;
    //public int coins = 0;
    //public int health = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

using UnityEngine.SceneManagement;
using UnityEngine.UI;
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

            DestroyImmediate(gameObject);
        }
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
 main
}