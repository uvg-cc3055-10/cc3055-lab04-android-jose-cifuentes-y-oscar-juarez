using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Navesita : MonoBehaviour {

    Rigidbody2D rb2d;
    float speed = 8f;
    public Text scoreTxt;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();               
    }
	
	// Update is called once per frame
	void Update () {

        GameController.instance.tiempo += Time.deltaTime;

        scoreTxt.text = "Score: " + GameController.instance.tiempo;

        float move = Input.acceleration.x;
        rb2d.transform.Translate(Vector2.right * speed * move * Time.deltaTime);        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.gameOver = true;

        float score = PlayerPrefs.GetFloat("record");

        if (score < GameController.instance.tiempo)
        {
            PlayerPrefs.SetFloat("record",GameController.instance.tiempo);
        }

        SceneManager.LoadScene("Menu");
    }

}
