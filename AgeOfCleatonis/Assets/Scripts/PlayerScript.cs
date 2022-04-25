using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float speed = 7f;
    private Animator amanam;
    private SpriteRenderer srajt;
    public int health = 5;
    public POV pov = POV.dolje;
    
    // Start is called before the first frame update
    void Start()
    {
        srajt = GetComponent<SpriteRenderer>();
        amanam = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            amanam.SetInteger("AnimState", 1);
            amanam.SetFloat("WalkX", 0);
            amanam.SetFloat("WalkY", 1);
            pov = POV.gore;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            amanam.SetInteger("AnimState", 1);
            amanam.SetFloat("WalkX", 0);
            amanam.SetFloat("WalkY", -1);
            //srajt.flipX = true;
            pov = POV.dolje;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            amanam.SetInteger("AnimState", 1);
            amanam.SetFloat("WalkX", -1);
            amanam.SetFloat("WalkY", 0);
            pov = POV.lijevo;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            amanam.SetInteger("AnimState", 1);
            amanam.SetFloat("WalkX", 1);
            amanam.SetFloat("WalkY", 0);
            pov = POV.desno;
        }
        else
        {
            amanam.SetInteger("AnimState", 0);
            if (pov == POV.gore)
            {
                amanam.SetFloat("IdleX", 0);
                amanam.SetFloat("IdleY", 1);
            }

            else if (pov == POV.dolje)
            {
                amanam.SetFloat("IdleX", 0);
                amanam.SetFloat("IdleY", -1);
            }

            else if (pov == POV.desno)
            {
                amanam.SetFloat("IdleX", 1);
                amanam.SetFloat("IdleY", 0);
                //srajt.flipX = false;
            }

            else if (pov == POV.lijevo)
            {
                amanam.SetFloat("IdleX", -1);
                amanam.SetFloat("IdleY", 0);
                //srajt.flipX = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            if (health == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}

public enum POV
{
    gore,
    dolje,
    desno,
    lijevo
}
