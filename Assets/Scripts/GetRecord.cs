using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetRecord : MonoBehaviour {

    public Text scoreTxt;

    // Use this for initialization
    void Start () {

        scoreTxt.text = "Tiempo record: \n" + PlayerPrefs.GetFloat("record");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
