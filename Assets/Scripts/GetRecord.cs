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
using UnityEngine.UI;
using UnityEngine;

public class GetRecord : MonoBehaviour {

    /*Declaracion de variables*/
    public Text scoreTxt;

    /*Cuando se comienza se ejecuta...*/
    void Start () {
        /*Se imprime el record en pantalla*/
        scoreTxt.text = "Tiempo record: \n" + PlayerPrefs.GetFloat("record");

    }

    /*por cada frame se ejecuta...*/
    void Update () {
		
	}
}
