using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public Text Healthtxt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Healthtxt.text = "Health:" + GameManager.instance.Health;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.Health--;

            if (GameManager.instance.Health <= 0)
            {
                SceneManager.LoadScene("GameOver");
                
                GameManager.instance.Health = 100;
            }
        }
    }
}
