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
using UnityEngine.SceneManagement;


public class Botonsito : MonoBehaviour {

    /*Declaracion de variables*/
    void Start () {
		
	}

    /*Cuando se comienza se ejecuta...*/
    void Update () {    
		
	}

    public void Click()
    {
        /*Se empieza el juego*/
        SceneManager.LoadScene("Principal");
    }
}
