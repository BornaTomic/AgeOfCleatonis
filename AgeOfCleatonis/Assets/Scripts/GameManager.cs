using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;        //instanciranje
    private void Awake()
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
