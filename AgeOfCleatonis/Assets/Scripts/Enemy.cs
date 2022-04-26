using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 10;
    public EnemyState currentState;
    public int maxHp = 10;
    public float pushRecSpeed = 0.1f;
    public float moveSpeed = 5f;

    protected float immuneTime = 1.0f;
    protected float lastImmune;

    protected Vector3 pushDirection;

    protected virtual void ReceiveDamage(DmgContainer dmg) //Kretene nakaradni tu si napisao RecIeveDmg umjesto ReceiveDamage jel ja na ovo moram vecer trosit, ovo se desi kad ne prokomentiras odma sta napises
    {
        if (Time.time - lastImmune > immuneTime) //Ako je Vrijeme - lastImmune(Zadnje "IMUN") vece od ImmuneTime, mozemo opet  primit dmg
        {
            lastImmune = Time.time; //postavljamo lastImmune da je trenutno vrijeme
            hp -= dmg.dmgAmmount;  //HP -= dmg nemoram puno rec
            pushDirection = (transform.position - dmg.origin).normalized * dmg.pushForce;  //samo smijer gdje ce biti odgurnut

            //GameManager.instance.Show(dmg.dmgAmmount.ToString(), 40, Color.red, transform.position, Vector3.zero, 0.5f); //Napomena ovdje je Vector3.zero jer netreba micanje tog efekta

            if (hp <= 0)
            {
                hp = 0;
                //Death(); //aj sam  napravi neko prebacivanje na game over scenu
            }
        }
    }
}

public enum EnemyState
{
    idle,
    walk
}
