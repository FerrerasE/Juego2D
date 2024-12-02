using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{

    [SerializeField] private float jumpForce = 4500f; // fuerza que aplicamos al saltar
    private bool isGrounded; //banadera que indica si el personaje esta en la plataforma
    private Rigidbody2D rb; // referencia al componente rigidbody2d del personaje
    private AudioSource audioSource; // referencia al audio

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // obtenemos la referencia al rigidbody2d del personaje
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        // llamamos a la funcion Jump () si el personaje esta en una plataforma y se presiona el boton de saltar
        if (isGrounded && Input.GetButtonDown("Jump")){
            Jump();
        }
    }
    // cuando el personaje colisiona con un objeto, se establece isGrounded como verdadero
    private void OnCollisionEnter2D(Collision2D collision){
        isGrounded = true;
    }
    // cuando el personaje deja de colisionar con un objeto, se establece isGrounded como falso
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
    // funcion que aplica una fuerza vertical para ejecutar el salto. Normalizamos el salto con deltaTime
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);
        //PlayJumpSound();
    }

    /**private void PlayJumpSound(){
        
        if (audioSource != null){
            audioSource.Play();
        }
    }*/
}

