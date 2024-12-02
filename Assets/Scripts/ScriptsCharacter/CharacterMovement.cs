using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
   // Start is called before the first frame update
    [SerializeField] private float movementSpeed = 2500f; //velocidad de movimiento del personaje

    private float limitRangeX; // variable privada que marca los limites de movimiento del jugador en el eje x
    //private float limitRangeY; // variable privada que marca los limites de movimiento del jugador en el eje y
    private bool isFacingRight = true; //respresenta el valor de mirar a la derecha
    private Rigidbody2D rb; //referencia al componente Rigibody2D del personaje
    
    public bool sePuedeMover = true; // variable que indica si el personaje se puede mover si no recibio golpe
    [SerializeField] private Vector2 velocidadRebote; // se toma la velocidad del personaje cuando recibe el daño



    public Animator ani;


    private void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>(); //Obtenemos la referencia al Rigibody2D del personaje
        limitRangeX = 15.26f; 
    }
     
     
    // Update is called once per frame
    private void Update()
    {
        //Damage();
        float movementX = Input.GetAxis("Horizontal");//obtenemos la entrada del moviemnto hoizontal (-1 a 1) y la almacenamos en movementX
        if (sePuedeMover) {
        Move(movementX * movementSpeed); //
        }
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
         // Este if limita la posicion del jugador hasta la izquierda
        if (gameObject.transform.position.x < -limitRangeX)
        {
            gameObject.transform.position = new Vector3(-limitRangeX,
                                                         gameObject.transform.position.y,
                                                         gameObject.transform.position.z);
        }
         // Este if limita la posicion del jugador hasta la derecha
         if (gameObject.transform.position.x > limitRangeX)
        {
            gameObject.transform.position = new Vector3(limitRangeX,
                                                         gameObject.transform.position.y,
                                                         gameObject.transform.position.z);
        }
        rb.velocity = new Vector2(velocity * Time.deltaTime, rb.velocity.y);
        
    }
    // cambiamos la escala en el eje X para voltear el personaje
    private void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = !isFacingRight;
    }

    public void Rebote(Vector2 puntoGolpe){
        rb.velocity = new Vector2(-velocidadRebote.x * puntoGolpe.x, velocidadRebote.y);

    }

    

   
}
