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

public class MeteoriteSpawner : MonoBehaviour
{
    /*Declaracion de variables*/
    public GameObject meteorito;
    public float spawnTime = 0.2f;
    public float elapsedTime = 0f;

    /*Cuando se comienza se ejecuta...*/
    void Start()
    {

    }

    /*por cada frame se ejecuta...*/
    void Update()
    {
        /*Mientras no haya muerto*/
        if (GameController.instance.gameOver == false)
        {
            /*se incrementa el lapso de la creacion de meteriotos*/
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime*2;
            }
            else
            {
                /*se crea un meteorito en una posicion al azar, partiendo desde arriba*/
                float random = Random.Range(-3f, 3f);                
                Instantiate(meteorito, new Vector3(random, 6, 0), Quaternion.identity);                
                elapsedTime = 0;
            }
        }

    }
}
