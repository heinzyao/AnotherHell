using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{

    public GameObject core;
    public Sprite pillarOn;
    public bool isPlayerOn;
    public int pillarNo;

    void Start()
    {
        isPlayerOn = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        isPlayerOn = true;
        Debug.Log("Enter");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isPlayerOn = false;
        Debug.Log("Exit");
    }

 
    void Update()
    {

        if (isPlayerOn && Input.GetKeyUp(KeyCode.Space))
        {
           
            bool correct = core.GetComponent<GameController>().CheckPillar(pillarNo);

            if (correct)
            {
                GetComponent<SpriteRenderer>().sprite = pillarOn;
            }

        }
        else
        {}
    }

}

