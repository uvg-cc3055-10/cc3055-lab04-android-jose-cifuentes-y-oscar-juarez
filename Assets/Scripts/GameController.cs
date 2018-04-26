/*
 * Universidad del Valle de Guate
 * Autores: 
 *          Jose Cifuentes - 17509
 *          Oscar Juarez   - 17315
 * Fecha:
 *          25/04/2018
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    /*Declaracion de variables*/
    public static GameController instance;
    public bool gameOver = false;
    public float tiempo = 0;

    /*Cuando se comienza se ejecuta...*/
    void Start () {
        /*Se refiere a su mismo objeto*/
        instance = this;
		
	}

    /*por cada frame se ejecuta...*/
    void Update () {
		
	}
}
