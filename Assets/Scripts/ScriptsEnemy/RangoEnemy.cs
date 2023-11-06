using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemy : MonoBehaviour
{
    public Animator ani;
    public Enemy1 enemigo;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Character"))
        {
           ani.SetBool("walk", false);
           ani.SetBool("run", false);
           ani.SetBool("attack", true);
           enemigo.atacando = true;
           GetComponent<BoxCollider2D>().enabled = false; 
           if (enemigo.atacando = true)
           {
            Debug.Log("le dieron un putazo a Aladdin");
           }           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
