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

public class Meteorito : MonoBehaviour {
    /*declaracion de variables*/
    Rigidbody2D rb2d;
    float speed = 5f;

    // cuando se comienza
    void Start () {
        /*Se jalan todas las componentes del Rigidbody */
        rb2d = GetComponent<Rigidbody2D>();
    }

    /*por cada frame se ejecuta...*/
    void Update () { 
                /*Mientras no haya muerto*/
        if (GameController.instance.gameOver == false)
        {
            /*movemos el meteorito de posicion */
            rb2d.transform.Translate(Vector2.down * speed * Time.deltaTime);

            /*si el meteorito sale del area visible se destruye el objeto*/
            if (transform.position.y < -5.57)
            {
                Destroy(gameObject);
            }            
        }              

    }
}
