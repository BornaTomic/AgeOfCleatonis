using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 IO
    public static GameManager instance;        //instanciranje
    private void Awake()

    public static GameManager instance;
    public GameObject GameUI;
    public GameObject PauseUI;
    public bool IsPaused = false;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance is null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
    void Start()
 main
    {
        if (GameManager.instance != null)                  //PROVJERA SINGLETONA OVO SVE VISE MANJE TAK DA ONO
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public int coins;
    public int hp;


}
