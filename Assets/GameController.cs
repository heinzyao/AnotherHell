using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int[] order;
    public int index;
    public GameObject[] pillars;
    public Sprite pillarOff;
    public GameObject chest;
    public Sprite chestOpen;
    public GameObject coin;
    public GameObject win;

    void Start()
    {
        ResetAllPillars();
        coin.SetActive(false);
    }

    public bool CheckPillar(int pillarNo)
    {
        if (order[index] == pillarNo)
        {
            if (index == 2)
            {
                Win();
                win.GetComponent<TextMesh>().text = "You Win !";
            }

            else
            {}
         
            index = index + 1;
            return true;
         
        }
        else
        {
            ResetAllPillars();
            return false;
        }
    }

    public void ResetAllPillars()
    {
        index = 0;
        for (int i = 0; i < 3; i++)
        {
            pillars[i].GetComponent<SpriteRenderer>().sprite = pillarOff;
        }
    }

    public void Win()
    {
        chest.GetComponent<SpriteRenderer>().sprite = chestOpen;
        coin.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

}