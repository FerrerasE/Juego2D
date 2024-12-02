using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemy : MonoBehaviour
{
    public Animator ani;
    public Enemy1 enemigo;

    void OnTriggerEnter2D(Collider2D coll)
    {
        //si hay colision, se cancela las animacion de caminar y correr, se activa la animacion de golpe
        if (coll.CompareTag("Character"))
        {
           ani.SetBool("walk", false);
           ani.SetBool("run", false);
           ani.SetBool("attack", true);
           enemigo.atacando = true;
           GetComponent<BoxCollider2D>().enabled = false;           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
