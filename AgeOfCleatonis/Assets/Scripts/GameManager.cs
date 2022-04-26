using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject GameUI;
    public GameObject PauseUI;
    public bool IsPaused = false;

    public int hp;

    TMP_Text text;
    public static int coinCounter = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        //if (instance is null)
        //{
        //    instance = this;
        //   DontDestroyOnLoad(this);
        //}
        //else
        //{
        //    DestroyImmediate(gameObject);
        //}
    }
    void Start()
    {
        if (GameManager.instance != null)                  //PROVJERA SINGLETONA OVO SVE VISE MANJE TAK DA ONO
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        text.text = "Coins: " + coinCounter + "/5";
    }
}
