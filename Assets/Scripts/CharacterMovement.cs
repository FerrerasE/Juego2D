using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
   // Start is called before the first frame update
    [SerializeField] private float movementSpeed = 1500f; //velocidad de movimiento del personaje
    private bool isFacingRight = true; //respresenta el valor de mirar a la derecha
    private Rigidbody2D rb; //referencia al componente Rigibody2D del personaje

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Obtenemos la referencia al Rigibody2D del personaje 
    }

    // Update is called once per frame
    private void Update()
    {
        float movementX = Input.GetAxis("Horizontal");//obtenemos la entrada del moviemnto hoizontal (-1 a 1) y la almacenamos en movementX
        Move(movementX * movementSpeed); //normalizamos al multiplicar por deltatime
        // giro del personaje si se mueve hacia la izquierda
        if (movementX < 0 && isFacingRight)
        {
            Flip();
        }
        //giro del personaje si se mueve a la derecha
        else if (movementX >0 && !isFacingRight)
        {
            Flip();
        }
    }
    
    // establecemos la velocidad del PJ para el movimiento horizontal
    public void Move(float velocity){
        rb.velocity = new Vector2(velocity * Time.deltaTime, rb.velocity.y);
    }
    // cambiamos la escala en el eje X para voltear el personaje
    private void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = !isFacingRight;
    }
}
