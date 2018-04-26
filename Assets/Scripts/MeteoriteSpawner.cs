using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteSpawner : MonoBehaviour
{

    public GameObject meteorito;
    public float spawnTime = 0.2f;
    public float elapsedTime = 0f;    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GameController.instance.gameOver == false)
        {
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime*2;
            }
            else
            {
                float random = Random.Range(-3f, 3f);                
                Instantiate(meteorito, new Vector3(random, 6, 0), Quaternion.identity);                
                elapsedTime = 0;
            }
        }

    }
}
