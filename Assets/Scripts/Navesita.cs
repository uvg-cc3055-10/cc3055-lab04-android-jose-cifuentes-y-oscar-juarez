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
using UnityEngine.SceneManagement;
using UnityEngine;

public class Navesita : MonoBehaviour
{
    /*Declaracion de variables*/
    Rigidbody2D rb2d;
    float speed = 8f;
    public Text scoreTxt;

    /*Cuando se comienza se ejecuta...*/
    void Start () {
        /*Se jalan todas las componentes del Rigidbody */
        rb2d = GetComponent<Rigidbody2D>();               
    }
	
	/*por cada frame se ejecuta...*/
	void Update () {
        /*se suma el tiempo a la variable localizada en el script GameController*/
        GameController.instance.tiempo += Time.deltaTime;

        /*Se actualiza en pantalla cuanto tiempo ha permanecido en vida*/
        scoreTxt.text = "Score: " + GameController.instance.tiempo;

        /*Se obtiene la posicion con ayuda del acelerometro y se mueve la nave espacial*/
        float move = Input.acceleration.x;
        rb2d.transform.Translate(Vector2.right * speed * move * Time.deltaTime);        

    }

    /*Cuando colisiona con un meteorito*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*La variable localizada en GameController la volvemos true*/
        /*Lo que significa que se acaba el juego*/
        GameController.instance.gameOver = true;

        /*Si en la partida actual se rompe el reord personal se actualiza la varibale*/
        float score = PlayerPrefs.GetFloat("record");
        if (score < GameController.instance.tiempo)
        {
            PlayerPrefs.SetFloat("record",GameController.instance.tiempo);
        }
        /*se regresa al menu*/
        SceneManager.LoadScene("Menu");
    }

}
