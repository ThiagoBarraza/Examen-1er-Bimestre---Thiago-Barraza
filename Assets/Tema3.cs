using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema3 : MonoBehaviour
{
    public int estadia;
    public string codigo;
    // Start is called before the first frame update
    void Start()
    {
        int comida = 0;
        bool valido = false;
        if(estadia > 3)
        {
            switch (codigo)
            {
                case "G":
                    comida = 300;
                    valido = true;
                    break;
                case "PP":
                    comida = 400;
                    valido = true;
                    break;
                case "PG":
                    comida = 700;
                    valido = true;
                    break;
                default:
                    Debug.Log("Codigo invalido");
                    break;



            }
            if(valido == true)
            {
                int comidatotal = estadia * comida;
                int costo = comidatotal / 100 * 80;

                Debug.Log("Para ese periodo se necsitan " + comidatotal + "g de comida");
                Debug.Log("con un costo total de " + costo + "$");
            }
            
        }
        else
        {
            Debug.Log("Estadia invalida");
        }
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}