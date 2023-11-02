using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    private Animator animator; // referencia al componente Animator del Personaje

    private void Start()
    {
       animator = GetComponent<Animator>(); // obtenemos la referncia al componente Animator
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0) // comparamos el valor del movimiento (-1 / 0 / 1)
        {
            animator.SetBool("isRunning", true); // activar la animacion de caminar
        }
        else
        {
            animator.SetBool("isRunning", false); // desactivar la animacion de caminar
        }
    }
    // cuando el personaje colisiona con el objeto, desactiva animacion de salto
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("isJumping", false); // desactiva la animacion de salto
    }
    // cuando el personaje deja de colisionar con un objeto, activa la animacion de salto
    private void OnCollisionExit2D(Collision2D collision)
    {
        animator.SetBool("isJumping", true); // activa la animacion de saltar
    }
}
