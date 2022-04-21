using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 7f;
    private Animator amanam;
    private SpriteRenderer srajt;
    public int health = 100;
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
            //amanam.SetInteger("AnimState", 1);
            //amanam.SetFloat("walkX", 0);
            //amanam.SetFloat("walkY", 1);
            pov = POV.gore;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            //amanam.SetInteger("AnimState", 1);
            //amanam.SetFloat("walkX", 0);
            //amanam.SetFloat("walkY", -1);
            srajt.flipX = true;
            pov = POV.dolje;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            //amanam.SetInteger("AnimState", 1);
            //amanam.SetFloat("walkX", -1);
            //amanam.SetFloat("walkY", 0);
            pov = POV.lijevo;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            //amanam.SetInteger("AnimState", 1);
            //amanam.SetFloat("walkX", 1);
            //amanam.SetFloat("walkY", 0);
            pov = POV.desno;
        }
        else
        {
            //amanam.SetInteger("AnimState", 0);
            if (pov == POV.gore)
            {
                //amanam.SetFloat("idleX", 0);
                //amanam.SetFloat("idleY", 1);
            }

            else if (pov == POV.dolje)
            {
                //amanam.SetFloat("idleX", 0);
                //amanam.SetFloat("idleY", -1);
            }

            else if (pov == POV.desno)
            {
                //amanam.SetFloat("idleX", 1);
                //amanam.SetFloat("idleY", 0);
                srajt.flipX = false;
            }

            else if (pov == POV.lijevo)
            {
                //amanam.SetFloat("idleX", -1);
                //amanam.SetFloat("idleY", 0);
                srajt.flipX = true;
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
