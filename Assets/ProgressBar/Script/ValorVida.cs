using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValorVida : MonoBehaviour
{
    public ProgressBar pb;

    public float valor = 100;

    public CharacterLife characterLife;
    // Start is called before the first frame update
    void Start()
    {
        //characterLife = GetComponent<CharacterLife>();
       
         
      
    }

    // Update is called once per frame
    void Update()
    {
        valor = characterLife.vida;
       pb.BarValue = valor;
    }
}
