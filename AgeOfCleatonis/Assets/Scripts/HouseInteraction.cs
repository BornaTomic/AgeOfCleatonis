using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HouseInteraction : MonoBehaviour
{
    public string sceneName;
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            dialogBox.SetActive(true);
            //dialogText.text = dialog;

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(sceneName);
            }
        }

        else if (!playerInRange)
        {
            dialogBox.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
