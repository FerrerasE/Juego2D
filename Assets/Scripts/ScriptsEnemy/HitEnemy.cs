using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Character"))
        {
            other.gameObject.GetComponent<CharacterLife>().TomarDaño(20, other.GetContact(0).normal);
           //other.GetComponent<CharacterMovement>().ani.SetTrigger("damage"); 
           //coll.GetComponent<CharacterLife>().TomarDaño(20, );
        }
     }

     

        /**public void OnTriggerEnter2D(Collider2D coll)
    {
        /**if (coll.CompareTag("Character"))
        {
            coll.GetComponent<CharacterMovement>().ani.SetTrigger("damage");
        }*/
        
        /**if (other.gameObject.CompareTag("Character"))
        {
            
           //other.GetComponent<CharacterLife>().TomarDaño(20));
        }/*
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //OnTriggerEnter2D(coll);
        //Brillo();
        /*
        coll.GetComponentInParent<Megaman_X>().audio_S.clip = coll.GetComponentInParent<Megaman_X>().sonido[3];
        coll.GetComponentInParent<Megaman_X>().audio_S.Play();
        */
    }

    /**void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Character"))
        {
            coll.GetComponent<CharacterMovement>().ani.SetTrigger("damage");
            coll.GetComponent<CharacterMovement>().damage1 = true;

            if (transform.position.x > coll.transform.position.x)
                {
                    coll.GetComponent<CharacterMovement>().empuje = -3;
                    coll.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    coll.GetComponent<CharacterMovement>().empuje = 3;
                    coll.transform.rotation = Quaternion.Euler(0, 180, 0);
                }




             /**
            if (coll.GetComponent<Megaman_X>().HP_Min > 0 && coll.GetComponent<Megaman_X>().damage_ == false)
            {
                coll.GetComponent<Megaman_X>().ani.SetTrigger("damage");
                coll.GetComponent<Megaman_X>().damage_ = true;

                coll.GetComponent<Megaman_X>().audio_S.clip = coll.GetComponent<Megaman_X>().sonido[3];
                coll.GetComponent<Megaman_X>().audio_S.Play();
            
                if (transform.position.x > coll.transform.position.x)
                {
                    coll.GetComponent<Megaman_X>().empuje = -3;
                    coll.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    coll.GetComponent<Megaman_X>().empuje = 3;
                    coll.transform.rotation = Quaternion.Euler(0, 180, 0);
                }

                coll.GetComponent<Megaman_X>().HP_Min -= Daño;
            }
    */
}
