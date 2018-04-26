﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Meteorito : MonoBehaviour {

    Rigidbody2D rb2d;
    float speed = 5f;
    public GameObject meteorito;    

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        meteorito = GetComponent<GameObject>();
    }
	
	// Update is called once per frame
	void Update () { 
                
        if (GameController.instance.gameOver == false)
        {
            rb2d.transform.Translate(Vector2.down * speed * Time.deltaTime);

            if (transform.position.y < -5.57)
            {
                Destroy(gameObject);
            }            
        }        
        //rb2d.transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);

    }
}
