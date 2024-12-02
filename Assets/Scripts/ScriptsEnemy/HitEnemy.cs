using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    private Collider2D gravedad;
    private Animator animator;

    private AudioSource audioSource; // referencia al audio

   
    
     private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Character"))
        {
           // foreach (ContactPoint2D punto in other.contacts)
            //{
            if (other.GetContact(0).normal.y <= -0.9)
            { 
                PlayJumpSound();
                animator.SetTrigger("herido");
                gravedad.isTrigger = true;
                other.gameObject.GetComponent<CharacterMovement>().Rebote(other.GetContact(0).normal);

            } else
            {
                animator.SetTrigger("attack");
              other.gameObject.GetComponent<CharacterLife>().TomarDaño(20, other.GetContact(0).normal);  
            }
            
            
        }
     }

     
       private void PlayJumpSound(){
        
        if (audioSource != null){
            audioSource.Play();
        }
    }
        

    public void final(){
        //Instantiate(explo, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        gravedad = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
