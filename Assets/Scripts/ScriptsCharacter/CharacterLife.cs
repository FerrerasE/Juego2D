using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLife : MonoBehaviour
{

    [SerializeField] private float vida;
    private CharacterMovement characterMovement;
    [SerializeField] private float tiempoPerdidaControl;
    private Animator animator;

    public void TomarDaño(float daño, Vector2 posicion){
        vida -= daño;
        animator.SetTrigger("damage"); //activa el trigger damage para activar animacion de personaje cuando recibe un golpe
        StartCoroutine(PerderControl());
        StartCoroutine(DesactivarDaño());
        characterMovement.Rebote(posicion);
         
    }
    
    /** Corrutina para activar los segundos en que el personaje es golpeado*/
    private IEnumerator PerderControl(){
        characterMovement.sePuedeMover = false;
        yield return new WaitForSeconds(tiempoPerdidaControl);
        characterMovement.sePuedeMover = true;
    }

     /** Corrutina para desactivar momentaneamente la colision del personaje con los enemigos*/
    private IEnumerator DesactivarDaño(){
        Physics2D.IgnoreLayerCollision(6,7,true);
        yield return new WaitForSeconds(tiempoPerdidaControl);
        Physics2D.IgnoreLayerCollision(6,7,false);
    }


    // Start is called before the first frame update
    void Start()
    {
      characterMovement = GetComponent<CharacterMovement>();
      animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
