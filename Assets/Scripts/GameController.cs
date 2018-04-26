using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public bool gameOver = false;
    public float tiempo = 0;
   
    // Use this for initialization
    void Start () {

        instance = this;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
